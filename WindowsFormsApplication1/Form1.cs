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
            //TODO: what's the equation?
            const int BadgeWidth  = 255;  // 90mm
            const int BadgeHeight = 156;  // 55mm

            graph.DrawRectangle(new Pen(Color.FromArgb(10,0,0,0), 1), new XRect(x, y, BadgeWidth, BadgeHeight));
            XPdfFontOptions pdfFondOptions = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // TODO: fonts are temporary
            // should get the default LaTeX font (Computer Modern), or sthg similarly sexy
            XFont fontNev = new XFont("Garamond", 16, XFontStyle.Bold, pdfFondOptions);
            XFont fontPoszt = new XFont("Garamond", 16, XFontStyle.Italic, pdfFondOptions);


            /*TODO: Add a default logo if there is not a browsed one, and check the size of the png!!*/
            XImage logo = XImage.FromFile(logo_Location.Text);
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

            XSize firstStrSize = graph.MeasureString(nev, fontNev);
            int lineNum = (int)(Math.Ceiling(firstStrSize.Width / Convert.ToDouble(textWidth)));

            tf.DrawString(nev, fontNev, XBrushes.Black, new XRect(textStartX, textStartY, textWidth, textHeight));
            tf.DrawString(poszt, fontPoszt, XBrushes.Black, new XRect(textStartX, textStartY+(lineNum*fontNev.Height), textWidth, textHeight));
            graph.DrawImage(logo, logoStartX, logoStartY, logoWidth, logoHeight);
            graph.DrawLine(new Pen(Color.Black, 1), lineStartX, lineStartY, lineEndX, lineEndY);
         }

        public Form1()
        {
            InitializeComponent();

            /*Default path*/
            XLS_location.Text  = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            logo_Location.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txt_pdfPath.Text   = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Badges";

            picBox_spinner.Image = Properties.Resources.progress;
            picBox_spinner.Visible = false;

            backgroundwoker.WorkerSupportsCancellation = true;
            backgroundwoker.WorkerReportsProgress = true;
            backgroundwoker.DoWork += new DoWorkEventHandler(bw_DoWork);
            backgroundwoker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_DoneGenerate);
            backgroundwoker.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch(e.ProgressPercentage)
            {
                case 1:
                    lbl_progress.Text = "Xls és png fileok megnyitása...";
                    break;
                case 2:
                    lbl_progress.Text = "xls feldolgozása...";
                    break;
                case 3:
                    lbl_progress.Text = "Badgek generálása...";
                    break;
                case 4:
                    lbl_progress.Text = "PDF mentése...";
                    break;
                default:
                    break;
            }
        }

        private void bw_DoneGenerate(object sender, RunWorkerCompletedEventArgs e)
        {
            picBox_spinner.Visible = false;
            button2.Enabled = true;
            lbl_progress.ForeColor = Color.DarkGreen;
            lbl_progress.Font = new System.Drawing.Font(lbl_progress.Font.Name, 24F);
            lbl_progress.Text = "Kész!";

            Timer doneSignTmr = new Timer();
            doneSignTmr.Interval = 5000;

            doneSignTmr.Tick += new EventHandler(showDoneSign);
            doneSignTmr.Start();
        }

        private void showDoneSign(object sender, EventArgs e)
        {
            lbl_progress.Font = new System.Drawing.Font(lbl_progress.Font.Name, 8.5F);
            lbl_progress.ForeColor = Color.Black;
            lbl_progress.Text = "";
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            backgroundwoker.ReportProgress(1);

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

            backgroundwoker.ReportProgress(2);

            List<Badge> badges = new List<Badge> { };
            foreach (Excel.Range row in r.Rows)
            {
                badges.Add(new Badge
                {
                    Nev = (row.Cells[1]).Value,
                    Poszt = (row.Cells[2]).Value
                });
            }

            badgerlist_wb.Close(false); // Close, discard changes

            IEnumerable<Badge> query =
                badges.OrderBy(element => element.Poszt).ThenBy(element => element.Nev);

            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            pdfPage.Size = PageSize.A4;
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);

            backgroundwoker.ReportProgress(3);

            int numPerPage = 0;
            Badge prevBadge = new Badge { Nev = "", Poszt = "" };
            foreach (Badge b in query)
            {
                numPerPage++;

                // Ha most tulcsordult, vagy uj poszt jon, de nem az elso lapon vagyunk...              
                if (((numPerPage == 11) || (b.Poszt != prevBadge.Poszt)) && !(prevBadge.Nev == "" && prevBadge.Poszt == ""))
                {
                    pdfPage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfPage);
                    pdfPage.Size = PageSize.A4;
                    numPerPage = 0;
                }

                /*
                 * DrawOneBadge call is fucked up, unreadable in this way.
                 */
                DrawOneBadge(graph, (numPerPage % 2 == 0) ? 255 : 0, (numPerPage % 2 == 0) ? ((numPerPage / 2) - 1) * 156 : (numPerPage - 1) / 2 * 156, b.Nev + "", b.Poszt + "", pdfPage.Width.Point, pdfPage.Height.Point);
                prevBadge = b;
            }

            backgroundwoker.ReportProgress(3);

            if ((string)e.Argument != String.Empty)
            {
                pdf.Save((string)e.Argument + "\\generatedBadges_" + DateTime.Now.TimeOfDay.Hours + DateTime.Now.TimeOfDay.Minutes + ".pdf");
            }
            else
            {
                pdf.Save("generatedBadges_" + DateTime.Now.TimeOfDay.Hours + DateTime.Now.TimeOfDay.Minutes + ".pdf");
            }
        }

        private void btn_browseXls_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog1.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                /*It may should be stored in a variable.*/
                XLS_location.Text = openFileDialog1.FileName;
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            picBox_spinner.Visible = true;
            button2.Enabled = false;
            backgroundwoker.RunWorkerAsync(txt_pdfPath.Text);
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

        private void btn_browsePdfPath_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_pdfPath.Text = fbd.SelectedPath;
            }
        }
    }
}


class Badge
{
    public string Nev { get; set; }
    public string Poszt { get; set; }
}