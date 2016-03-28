using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Badger
{
    public class BadgeCreator
    {
        private BackgroundWorker badgerWorker = new BackgroundWorker();
        private string XLSlocation = null;
        private string pdfSaveLocation = null;
        private string logoLocation = null;
        private Form parent = null;
        private List<Badge> badgeData = null;
        private string generatedPDFPath= null;
        private bool openAfterGenerate = false;

        public BadgeCreator(Form Parent, string xlsPath, string pdfSavePath, string logoPath, bool openPDF)
        {
            this.XLSlocation = xlsPath;
            this.pdfSaveLocation = pdfSavePath;
            this.logoLocation = logoPath;
            this.parent = Parent;
            this.openAfterGenerate = openPDF;
        }

        public BadgeCreator(Form Parent, List<Badge> badgeData, bool openPDF)
        {
            this.parent = Parent;
            this.badgeData = badgeData;
            this.openAfterGenerate = openPDF;
        }

        public void StartGenerate()
        {
            this.badgerWorker.WorkerSupportsCancellation = true;
            this.badgerWorker.WorkerReportsProgress = true;
            this.badgerWorker.DoWork += new DoWorkEventHandler(GenerateBadges);
            this.badgerWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(GenerateFinished);
            this.badgerWorker.RunWorkerAsync();
            ((MainForm)this.parent).showSpinner(true);//TODO: this is ugly?
        }

        private void GenerateFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            ((MainForm)this.parent).showSpinner(false);

            if (this.openAfterGenerate == true)
            { Process.Start(this.generatedPDFPath); }
            
        }

        private void GenerateBadges(object sender, DoWorkEventArgs e)
        {
            if (this.XLSlocation != null)
            {
                CreateBadges(Xls2Badges());
            }
            else {
                CreateBadges(this.badgeData);
            }
        }

        private List<Badge> Xls2Badges()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            const string sheetOfBadgeData = "BADGER_LIST";
            List<Badge> resultBadges = new List<Badge> { };

            // open, as read-only!
            Excel.Workbook badgerlist_workbook = excelApp.Workbooks.Open(
                this.XLSlocation, /*Path to .xls*/
                0,
                true, 
                5, 
                "", 
                "", 
                false, 
                Excel.XlPlatform.xlWindows, 
                "",
                true, 
                false, 
                0, 
                true, 
                false, 
                false
             );

            Excel.Sheets badgerlist_shts = badgerlist_workbook.Worksheets;         
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)badgerlist_shts.get_Item(sheetOfBadgeData);

            /*TODO: This is too static*/
            Excel.Range lastrow = excelWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range usefulRange = (Excel.Range)excelWorksheet.Range["A2", lastrow];

            foreach (Excel.Range row in usefulRange.Rows)
            {
                resultBadges.Add(new Badge(row.Cells[1].Value, row.Cells[2].Value));
            }

            badgerlist_workbook.Close(false);

            return resultBadges;
        }

        private void DrawOneBadge(XGraphics graph, int x, int y, string nev, string poszt, double wp, double hp)
        {
            const int BadgeWidth = 255;  // 90mm
            const int BadgeHeight = 156;  // 55mm

            graph.DrawRectangle(new Pen(Color.FromArgb(10, 0, 0, 0), 1), new XRect(x, y, BadgeWidth, BadgeHeight));
            XPdfFontOptions pdfFondOptions = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            XFont fontName = new XFont("Garamond", 16, XFontStyle.Bold, pdfFondOptions);
            XFont fontPos  = new XFont("Garamond", 16, XFontStyle.Italic, pdfFondOptions);

            XImage logo = null;

            if (this.logoLocation != null)
            {
                logo = XImage.FromFile(this.logoLocation);
            }
            else
            {
                logo = XImage.FromGdiPlusImage(Properties.Resources.logo);
            }

            double logoRatio = (double)logo.PixelWidth / (double)logo.PixelHeight;  // ~0.5
            int logoHeight = (int)((double)BadgeHeight * 0.8);
            int logoWidth = (int)Math.Floor(logoHeight * logoRatio);
            int badgeVerticalMargin = 10;

            int logoStartX = x + BadgeWidth - badgeVerticalMargin - logoWidth;
            int logoStartY = y + (int)Math.Floor((double)BadgeHeight - (double)logoHeight) / 2;

            double linePercentage = 0.8;
            int lineStartX = x + BadgeWidth - logoWidth - (2 * badgeVerticalMargin);
            int lineStartY = y + (int)(((1 - linePercentage) * BadgeHeight) / 2);
            int lineEndX = lineStartX;
            int lineEndY = lineStartY + (int)(linePercentage * BadgeHeight);

            int textStartX = x + badgeVerticalMargin;
            int textStartY = y + badgeVerticalMargin + fontName.Height;
            int textWidth = BadgeWidth - 4 * badgeVerticalMargin - logoWidth;
            int textHeight = logoWidth;

            PdfSharp.Drawing.Layout.XTextFormatter textFormatter = new XTextFormatter(graph);
            textFormatter.Alignment = XParagraphAlignment.Center;
            textFormatter.LayoutRectangle = new XRect(textStartX, textStartY, textWidth, textHeight);

            XSize firstStrSize = graph.MeasureString(nev, fontName);
            int lineNum = (int)(Math.Ceiling(firstStrSize.Width / Convert.ToDouble(textWidth)));

            textFormatter.DrawString(nev, fontName, XBrushes.Black, new XRect(textStartX, textStartY, textWidth, textHeight));
            textFormatter.DrawString(poszt, fontPos, XBrushes.Black, new XRect(textStartX, textStartY + (lineNum * fontName.Height), textWidth, textHeight));
            graph.DrawImage(logo, logoStartX, logoStartY, logoWidth, logoHeight);
            graph.DrawLine(new Pen(Color.Black, 1), lineStartX, lineStartY, lineEndX, lineEndY);
        }

        private void CreateBadges(List<Badge> badgesData)
        {        
            PdfDocument pdfDocument = new PdfDocument();
            PdfPage pdfPage = pdfDocument.AddPage();
            pdfPage.Size = PageSize.A4;
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            Badge prevBadge = new Badge("","");
            int numPerPage = 0;
            uint row = 0;
            int y = 0;
            int x = 0;

            badgesData.OrderBy(element => element.Pos).ThenBy(element => element.Name);
            

            foreach (Badge currentBadge in badgesData)
            {
                numPerPage++;

                // Ha most tulcsordult, vagy uj poszt jon, de nem az elso lapon vagyunk...              
                if (((numPerPage >8) || (currentBadge.Pos != prevBadge.Pos)) && !(prevBadge.Name == "" && prevBadge.Pos == ""))
                {
                    pdfPage = pdfDocument.AddPage();
                    pdfPage.Size = PageSize.A4;
                    graph = XGraphics.FromPdfPage(pdfPage);
                    numPerPage = 1;
                    row = 0;
                    y = 0;
                }

                
                y = (int)row * 156;
                x = ((numPerPage % 2) == 0) ? 255 : 0;
               
                DrawOneBadge(graph, x, y, currentBadge.Name, currentBadge.Pos, pdfPage.Width.Point, pdfPage.Height.Point);
                prevBadge = currentBadge;
                if (numPerPage % 2 == 0)
                { row++; }
            }

            if (this.pdfSaveLocation != null)
            {
                this.generatedPDFPath = this.pdfSaveLocation + "\\generatedBadges_" + DateTime.Now.TimeOfDay.Hours + DateTime.Now.TimeOfDay.Minutes + ".pdf";
                pdfDocument.Save(this.generatedPDFPath);
            }
            else
            {
                this.generatedPDFPath = "generatedBadges_" + DateTime.Now.TimeOfDay.Hours + DateTime.Now.TimeOfDay.Minutes + ".pdf";
                pdfDocument.Save(this.generatedPDFPath);
            }
        }

    }
}
