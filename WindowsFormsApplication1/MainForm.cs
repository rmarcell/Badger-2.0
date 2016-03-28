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

namespace Badger
{
    public partial class MainForm : Form
    {
        void FillPage()
        {

        }

       

        public MainForm()
        {
            InitializeComponent();
            
            txt_pdfPath.Text   = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Badges";

            picBox_spinner.Image = Properties.Resources.progress;
            picBox_spinner.Visible = false;

            lst_newBadges.Columns.Add("Név", lst_newBadges.Width/2);
            lst_newBadges.Columns.Add("Poszt", lst_newBadges.Width/2);
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
        
        private void btn_browseXls_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            openFileDialog1.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XLS_location.Text = openFileDialog1.FileName;
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            BadgeCreator bc = new BadgeCreator(this, this.XLS_location.Text, this.txt_pdfPath.Text, this.logo_Location.Text);
            bc.StartGenerate();
        }

        public void showSpinner(bool endis)
        {
            switch (endis)
            { 
                case true:
                    picBox_spinner.Visible = true;
                    button2.Enabled = false;
                    break;
                case false:
                    picBox_spinner.Visible = false;
                    button2.Enabled = true;
                    break;
                default:
                    break;
            }
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

        private void btn_browsePdfPath_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_pdfPath.Text = fbd.SelectedPath;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if(txt_name.Text == "Név")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_pos_Enter(object sender, EventArgs e)
        {
            if (txt_pos.Text == "Poszt")
            {
                txt_pos.Text = "";
                txt_pos.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == String.Empty)
            {
                txt_name.Text = "Név";
                txt_name.ForeColor = Color.Gray;
            }
        }

        private void txt_pos_Leave(object sender, EventArgs e)
        {
            if (txt_pos.Text == String.Empty)
            {
                txt_pos.Text = "Poszt";
                txt_pos.ForeColor = Color.Gray;
            }
        }

        private void btn_addBadge_Click(object sender, EventArgs e)
        {
            lst_newBadges.Items.Add(new ListViewItem(new String[] {txt_name.Text, txt_pos.Text}));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            List<Badge> newBadges= new List<Badge>();
            BadgeCreator bc = null;
            txt_name.Text = "Név";
            txt_name.ForeColor = Color.Gray;
            txt_pos.Text = "Poszt";
            txt_pos.ForeColor = Color.Gray;


            for (int cnt = 0; cnt < lst_newBadges.Items.Count; cnt++ )
            {
                Badge badge = new Badge();
                badge.Name = lst_newBadges.Items[cnt].SubItems[0].Text;
                badge.Pos = lst_newBadges.Items[cnt].SubItems[1].Text;
                newBadges.Add(badge);
            }

            bc = new BadgeCreator(this, newBadges);
            bc.StartGenerate();
            
        }
    }
}
