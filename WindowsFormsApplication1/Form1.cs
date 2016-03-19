using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using PdfSharp.Drawing.Layout;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        void FillPage()
        {

        }

        // TODO: wp, hp??
        void DrawOneBadge(XGraphics graph, int x, int y, string nev, string poszt, double wp, double hp)
        {
            int BadgeWidth  = 255;  // 90mm
            int BadgeHeight = 156;  // 55mm

            graph.DrawRectangle(new Pen(Color.Black, 1), new XRect(x, y, BadgeWidth, BadgeHeight));
            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // TODO: fonts are temporary
            // should get the default LaTeX font (Computer Modern), or sthg similarly sexy
            XFont fontNev = new XFont("Garamond", 16, XFontStyle.Bold, options);
            XFont fontPoszt = new XFont("Garamond", 16, XFontStyle.Italic, options);

            XImage logo = XImage.FromFile("C:/Users/xxxx/Documents/Visual Studio 2015/Projects/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/Inputs/logo.png");
            double logoRatio = (double)logo.PixelWidth / (double)logo.PixelHeight;  // ~0.5
            int logoHeight = (int)((double)BadgeHeight*0.8);
            int logoWidth  = (int)Math.Floor(logoHeight * logoRatio);
            int badgeVerticalMargin =10;

            int logoStartX = x + BadgeWidth - badgeVerticalMargin - logoWidth;
            int logoStartY = y + (int)Math.Floor((double)BadgeHeight - (double)logoHeight) / 2;

            double linePercentage = 0.8;
            int lineStartX = x + BadgeWidth - logoWidth - (2 * badgeVerticalMargin);
            int lineStartY = y + (int)(((1-linePercentage) * BadgeHeight) / 2);
            int lineEndX = lineStartX;
            int lineEndY = lineStartY + (int)(linePercentage * BadgeHeight);

            int textStartX = x + badgeVerticalMargin;
            int textStartY = y + badgeVerticalMargin + fontNev.Height;
            int textWidth = BadgeWidth - 4 * badgeVerticalMargin - logoWidth;
            int textHeight = logoWidth;

            PdfSharp.Drawing.Layout.XTextFormatter tf = new XTextFormatter(graph);
            tf.Alignment = XParagraphAlignment.Center;
            tf.LayoutRectangle = new XRect(textStartX, textStartY, textWidth, textHeight);

            // TODO: Egymasba log...
            tf.DrawString(nev, fontNev, XBrushes.Black, new XRect(textStartX, textStartY, textWidth, textHeight));
            tf.DrawString(poszt, fontPoszt, XBrushes.Black, new XRect(textStartX, textStartY+fontNev.Height, textWidth, textHeight));
            graph.DrawImage(logo, logoStartX, logoStartY, logoWidth, logoHeight);
            graph.DrawLine(new Pen(Color.Black, 1), lineStartX, lineStartY, lineEndX, lineEndY);
            }

        public Form1()
        {
            InitializeComponent();

            // Debug
            XLS_location.Text = "C:/Users/xxxx/Documents/Visual Studio 2015/Projects/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/Badgerlist2015.xlsx";
            logo_Location.Text = "C:/Users/xxxx/Documents/Visual Studio 2015/Projects/WindowsFormsApplication1/WindowsFormsApplication1/bin/Debug/Inputs/logo.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog1.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XLS_location.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;   // default is false, but to be sure...

            // open, as read-only!
            Excel.Workbook badgerlist_wb = excelApp.Workbooks.Open(XLS_location.Text,
                0, true, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
                true, false, 0, true, false, false);

            Excel.Sheets badgerlist_shts = badgerlist_wb.Worksheets;

            string currentSheet = "BADGER_LIST";
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)badgerlist_shts.get_Item(currentSheet);

            // TODO: safety checkup missing:
            // - empty lines
            // - file consistency
            // - etc.
            Excel.Range lastrow = excelWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range r =
                    (Excel.Range)excelWorksheet.Range["A2", lastrow];

            List<Badge> badges = new List<Badge> { };
            foreach (Excel.Range row in r.Rows)
            {
                badges.Add(new Badge {
                    Nev     = (row.Cells[1]).Value,
                    Poszt   = (row.Cells[2]).Value });
            }

            badgerlist_wb.Close(false); // Close, discard changes

            IEnumerable<Badge> query = 
                badges.OrderBy(element => element.Poszt).ThenBy(element => element.Nev);

            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            pdfPage.Size = PageSize.A4;
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            int numPerPage = 0;
            Badge prevBadge = new Badge{Nev="", Poszt=""};
            foreach (Badge b in query)
            {
                numPerPage++;

                // Ha most tulcsordult, vagy uj poszt jon, de nem az elso lapon vagyunk...              
                if (((numPerPage == 11) || (b.Poszt != prevBadge.Poszt)) && !(prevBadge.Nev == "" && prevBadge.Poszt ==""))
                {
                    pdfPage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfPage);
                    pdfPage.Size = PageSize.A4;
                    numPerPage = 0;
                }

                DrawOneBadge(graph, (numPerPage % 2 == 0) ? 255 : 0, (numPerPage % 2 == 0) ? ((numPerPage / 2) - 1) * 156 : (numPerPage - 1) / 2 * 156, b.Nev + "", b.Poszt + "", pdfPage.Width.Point, pdfPage.Height.Point);
                prevBadge = b;
            }

            pdf.Save("firstpage.pdf");
            MessageBox.Show("DONE");
        }
                
        
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openLogo = new OpenFileDialog();

            openLogo.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openLogo.Filter = "PNG files (*.png)|*.png";
            openLogo.FilterIndex = 1;
            openLogo.RestoreDirectory = true;

            if (openLogo.ShowDialog() == DialogResult.OK)
            {
                logo_Location.Text = openLogo.FileName;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Control contrl in this.potlolagos.Controls)
            {
                // A KURVA ANYADAT NEVEZGESD VISSZA, BASZOD...
                Debug.WriteLine(contrl.Name);
                if ((contrl.Name == ("textBox" + i.ToString())) && (contrl.Text!=""))
                {
                    MessageBox.Show(contrl.Text);
                }
                i = i + 1;
            }
        }
    }
}


class Badge
{
    public string Nev { get; set; }
    public string Poszt { get; set; }
}