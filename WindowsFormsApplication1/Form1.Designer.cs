namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundwoker = new System.ComponentModel.BackgroundWorker();
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
            this.lbl_progress.Location = new System.Drawing.Point(209, 337);
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
            this.potlolagos.Controls.Add(this.button3);
            this.potlolagos.Controls.Add(this.textBox17);
            this.potlolagos.Controls.Add(this.label19);
            this.potlolagos.Controls.Add(this.textBox18);
            this.potlolagos.Controls.Add(this.label20);
            this.potlolagos.Controls.Add(this.textBox19);
            this.potlolagos.Controls.Add(this.label21);
            this.potlolagos.Controls.Add(this.textBox20);
            this.potlolagos.Controls.Add(this.label22);
            this.potlolagos.Controls.Add(this.checkBox1);
            this.potlolagos.Controls.Add(this.button6);
            this.potlolagos.Controls.Add(this.button5);
            this.potlolagos.Controls.Add(this.textBox9);
            this.potlolagos.Controls.Add(this.label10);
            this.potlolagos.Controls.Add(this.textBox10);
            this.potlolagos.Controls.Add(this.label11);
            this.potlolagos.Controls.Add(this.textBox11);
            this.potlolagos.Controls.Add(this.label12);
            this.potlolagos.Controls.Add(this.textBox12);
            this.potlolagos.Controls.Add(this.label13);
            this.potlolagos.Controls.Add(this.textBox13);
            this.potlolagos.Controls.Add(this.label14);
            this.potlolagos.Controls.Add(this.textBox14);
            this.potlolagos.Controls.Add(this.label15);
            this.potlolagos.Controls.Add(this.textBox15);
            this.potlolagos.Controls.Add(this.label16);
            this.potlolagos.Controls.Add(this.textBox16);
            this.potlolagos.Controls.Add(this.label17);
            this.potlolagos.Controls.Add(this.textBox5);
            this.potlolagos.Controls.Add(this.label6);
            this.potlolagos.Controls.Add(this.textBox6);
            this.potlolagos.Controls.Add(this.label7);
            this.potlolagos.Controls.Add(this.textBox7);
            this.potlolagos.Controls.Add(this.label8);
            this.potlolagos.Controls.Add(this.textBox8);
            this.potlolagos.Controls.Add(this.label9);
            this.potlolagos.Controls.Add(this.textBox3);
            this.potlolagos.Controls.Add(this.label4);
            this.potlolagos.Controls.Add(this.textBox4);
            this.potlolagos.Controls.Add(this.label5);
            this.potlolagos.Controls.Add(this.textBox2);
            this.potlolagos.Controls.Add(this.label3);
            this.potlolagos.Controls.Add(this.textBox1);
            this.potlolagos.Controls.Add(this.label2);
            this.potlolagos.Location = new System.Drawing.Point(4, 22);
            this.potlolagos.Name = "potlolagos";
            this.potlolagos.Padding = new System.Windows.Forms.Padding(3);
            this.potlolagos.Size = new System.Drawing.Size(526, 396);
            this.potlolagos.TabIndex = 1;
            this.potlolagos.Text = "Pót badge";
            this.potlolagos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Törlés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(275, 254);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Poszt";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(82, 254);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Név";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(275, 228);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(225, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Poszt";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(82, 228);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(32, 228);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Név";
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "Megnyit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Nyomtat";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(275, 202);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Poszt";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(82, 202);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Név";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(275, 176);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Poszt";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(82, 176);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Név";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(275, 150);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Poszt";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(82, 150);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Név";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(275, 124);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Poszt";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(82, 124);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Név";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(275, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Poszt";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(82, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Név";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(275, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Poszt";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(82, 72);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Név";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Poszt";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Név";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poszt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logo_Location;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_browseImg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_pdfPath;
        private System.Windows.Forms.Button btn_browsePdfPath;
        private System.Windows.Forms.PictureBox picBox_spinner;
        private System.ComponentModel.BackgroundWorker backgroundwoker;
        private System.Windows.Forms.Label lbl_progress;
    }
}

