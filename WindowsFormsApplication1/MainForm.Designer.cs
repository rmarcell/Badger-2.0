namespace Badger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_browseXls = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.XLS_location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.elozetes = new System.Windows.Forms.TabPage();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.picBox_spinner = new System.Windows.Forms.PictureBox();
            this.btn_browsePdfPath = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_pdfPath = new System.Windows.Forms.TextBox();
            this.logo_Location = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_browseImg = new System.Windows.Forms.Button();
            this.potlolagos = new System.Windows.Forms.TabPage();
            this.lst_newBadges = new System.Windows.Forms.ListView();
            this.btn_addBadge = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.backgroundwoker = new System.ComponentModel.BackgroundWorker();
            this.cb_openPDF_singleBadge = new System.Windows.Forms.CheckBox();
            this.cb_openPDF_fromXLS = new System.Windows.Forms.CheckBox();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.elozetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_spinner)).BeginInit();
            this.potlolagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browseXls
            // 
            this.btn_browseXls.Location = new System.Drawing.Point(429, 50);
            this.btn_browseXls.Name = "btn_browseXls";
            this.btn_browseXls.Size = new System.Drawing.Size(75, 23);
            this.btn_browseXls.TabIndex = 0;
            this.btn_browseXls.Text = "XLS(X) input";
            this.btn_browseXls.UseVisualStyleBackColor = true;
            this.btn_browseXls.Click += new System.EventHandler(this.btn_browseXls_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // XLS_location
            // 
            this.XLS_location.Location = new System.Drawing.Point(116, 52);
            this.XLS_location.Name = "XLS_location";
            this.XLS_location.Size = new System.Drawing.Size(307, 20);
            this.XLS_location.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bemeneti XLS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generálás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.elozetes);
            this.tabControl1.Controls.Add(this.potlolagos);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 422);
            this.tabControl1.TabIndex = 5;
            // 
            // elozetes
            // 
            this.elozetes.Controls.Add(this.cb_openPDF_fromXLS);
            this.elozetes.Controls.Add(this.lbl_progress);
            this.elozetes.Controls.Add(this.picBox_spinner);
            this.elozetes.Controls.Add(this.btn_browsePdfPath);
            this.elozetes.Controls.Add(this.label23);
            this.elozetes.Controls.Add(this.txt_pdfPath);
            this.elozetes.Controls.Add(this.logo_Location);
            this.elozetes.Controls.Add(this.label18);
            this.elozetes.Controls.Add(this.btn_browseImg);
            this.elozetes.Controls.Add(this.XLS_location);
            this.elozetes.Controls.Add(this.label1);
            this.elozetes.Controls.Add(this.button2);
            this.elozetes.Controls.Add(this.btn_browseXls);
            this.elozetes.Location = new System.Drawing.Point(4, 22);
            this.elozetes.Name = "elozetes";
            this.elozetes.Padding = new System.Windows.Forms.Padding(3);
            this.elozetes.Size = new System.Drawing.Size(526, 396);
            this.elozetes.TabIndex = 0;
            this.elozetes.Text = "Előzetes generálás";
            this.elozetes.UseVisualStyleBackColor = true;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(209, 330);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(0, 13);
            this.lbl_progress.TabIndex = 12;
            this.lbl_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_spinner
            // 
            this.picBox_spinner.Location = new System.Drawing.Point(212, 218);
            this.picBox_spinner.Name = "picBox_spinner";
            this.picBox_spinner.Size = new System.Drawing.Size(120, 100);
            this.picBox_spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_spinner.TabIndex = 11;
            this.picBox_spinner.TabStop = false;
            this.picBox_spinner.Visible = false;
            // 
            // btn_browsePdfPath
            // 
            this.btn_browsePdfPath.Location = new System.Drawing.Point(429, 126);
            this.btn_browsePdfPath.Name = "btn_browsePdfPath";
            this.btn_browsePdfPath.Size = new System.Drawing.Size(75, 23);
            this.btn_browsePdfPath.TabIndex = 6;
            this.btn_browsePdfPath.Text = "Tallózás";
            this.btn_browsePdfPath.UseVisualStyleBackColor = true;
            this.btn_browsePdfPath.Click += new System.EventHandler(this.btn_browsePdfPath_Click_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(42, 131);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "PDF kimenet";
            // 
            // txt_pdfPath
            // 
            this.txt_pdfPath.Location = new System.Drawing.Point(116, 128);
            this.txt_pdfPath.Name = "txt_pdfPath";
            this.txt_pdfPath.Size = new System.Drawing.Size(307, 20);
            this.txt_pdfPath.TabIndex = 8;
            // 
            // logo_Location
            // 
            this.logo_Location.Location = new System.Drawing.Point(116, 91);
            this.logo_Location.Name = "logo_Location";
            this.logo_Location.Size = new System.Drawing.Size(307, 20);
            this.logo_Location.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Bemeneti kép";
            // 
            // btn_browseImg
            // 
            this.btn_browseImg.Location = new System.Drawing.Point(429, 89);
            this.btn_browseImg.Name = "btn_browseImg";
            this.btn_browseImg.Size = new System.Drawing.Size(75, 23);
            this.btn_browseImg.TabIndex = 5;
            this.btn_browseImg.Text = "Kép input";
            this.btn_browseImg.UseVisualStyleBackColor = true;
            this.btn_browseImg.Click += new System.EventHandler(this.button4_Click);
            // 
            // potlolagos
            // 
            this.potlolagos.Controls.Add(this.btn_deleteItem);
            this.potlolagos.Controls.Add(this.cb_openPDF_singleBadge);
            this.potlolagos.Controls.Add(this.lst_newBadges);
            this.potlolagos.Controls.Add(this.btn_addBadge);
            this.potlolagos.Controls.Add(this.checkBox1);
            this.potlolagos.Controls.Add(this.btn_print);
            this.potlolagos.Controls.Add(this.txt_pos);
            this.potlolagos.Controls.Add(this.txt_name);
            this.potlolagos.Location = new System.Drawing.Point(4, 22);
            this.potlolagos.Name = "potlolagos";
            this.potlolagos.Padding = new System.Windows.Forms.Padding(3);
            this.potlolagos.Size = new System.Drawing.Size(526, 396);
            this.potlolagos.TabIndex = 1;
            this.potlolagos.Text = "Pót badge";
            this.potlolagos.UseVisualStyleBackColor = true;
            // 
            // lst_newBadges
            // 
            this.lst_newBadges.Location = new System.Drawing.Point(35, 48);
            this.lst_newBadges.Name = "lst_newBadges";
            this.lst_newBadges.Size = new System.Drawing.Size(349, 252);
            this.lst_newBadges.TabIndex = 37;
            this.lst_newBadges.UseCompatibleStateImageBehavior = false;
            this.lst_newBadges.View = System.Windows.Forms.View.Details;
            // 
            // btn_addBadge
            // 
            this.btn_addBadge.Location = new System.Drawing.Point(429, 18);
            this.btn_addBadge.Name = "btn_addBadge";
            this.btn_addBadge.Size = new System.Drawing.Size(75, 23);
            this.btn_addBadge.TabIndex = 36;
            this.btn_addBadge.Text = "Hozzáad";
            this.btn_addBadge.UseVisualStyleBackColor = true;
            this.btn_addBadge.Click += new System.EventHandler(this.btn_addBadge_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Színek invertálása";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(429, 77);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 32;
            this.btn_print.Text = "Nyomtat";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_pos
            // 
            this.txt_pos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_pos.Location = new System.Drawing.Point(217, 21);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(167, 20);
            this.txt_pos.TabIndex = 3;
            this.txt_pos.Text = "Poszt";
            this.txt_pos.Enter += new System.EventHandler(this.txt_pos_Enter);
            this.txt_pos.Leave += new System.EventHandler(this.txt_pos_Leave);
            // 
            // txt_name
            // 
            this.txt_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.Location = new System.Drawing.Point(35, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(167, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Név";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // backgroundwoker
            // 
            this.backgroundwoker.WorkerReportsProgress = true;
            this.backgroundwoker.WorkerSupportsCancellation = true;
            // 
            // cb_openPDF_singleBadge
            // 
            this.cb_openPDF_singleBadge.AutoSize = true;
            this.cb_openPDF_singleBadge.Location = new System.Drawing.Point(35, 329);
            this.cb_openPDF_singleBadge.Name = "cb_openPDF_singleBadge";
            this.cb_openPDF_singleBadge.Size = new System.Drawing.Size(103, 17);
            this.cb_openPDF_singleBadge.TabIndex = 38;
            this.cb_openPDF_singleBadge.Text = "PDF megnyitása";
            this.cb_openPDF_singleBadge.UseVisualStyleBackColor = true;
            // 
            // cb_openPDF_fromXLS
            // 
            this.cb_openPDF_fromXLS.AutoSize = true;
            this.cb_openPDF_fromXLS.Location = new System.Drawing.Point(46, 218);
            this.cb_openPDF_fromXLS.Name = "cb_openPDF_fromXLS";
            this.cb_openPDF_fromXLS.Size = new System.Drawing.Size(103, 17);
            this.cb_openPDF_fromXLS.TabIndex = 13;
            this.cb_openPDF_fromXLS.Text = "PDF megnyitása";
            this.cb_openPDF_fromXLS.UseVisualStyleBackColor = true;
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(429, 48);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteItem.TabIndex = 39;
            this.btn_deleteItem.Text = "Eltávolít";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Badger 2.0";
            this.tabControl1.ResumeLayout(false);
            this.elozetes.ResumeLayout(false);
            this.elozetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_spinner)).EndInit();
            this.potlolagos.ResumeLayout(false);
            this.potlolagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_browseXls;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox XLS_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage elozetes;
        private System.Windows.Forms.TabPage potlolagos;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.TextBox logo_Location;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_browseImg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_pdfPath;
        private System.Windows.Forms.Button btn_browsePdfPath;
        private System.Windows.Forms.PictureBox picBox_spinner;
        private System.ComponentModel.BackgroundWorker backgroundwoker;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Button btn_addBadge;
        private System.Windows.Forms.ListView lst_newBadges;
        private System.Windows.Forms.CheckBox cb_openPDF_singleBadge;
        private System.Windows.Forms.CheckBox cb_openPDF_fromXLS;
        private System.Windows.Forms.Button btn_deleteItem;
    }
}

