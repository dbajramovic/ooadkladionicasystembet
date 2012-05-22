namespace GUI
{
    partial class UredjivanjeZaposlenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UredjivanjeZaposlenika));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mt_z_pass2 = new System.Windows.Forms.MaskedTextBox();
            this.mt_z_pass1 = new System.Windows.Forms.MaskedTextBox();
            this.t_z_jmbg = new System.Windows.Forms.TextBox();
            this.t_z_ime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_trazi = new System.Windows.Forms.Button();
            this.lstAudioDevices = new System.Windows.Forms.ListBox();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panelVideoPreview = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Uslikaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAudioDevices);
            this.groupBox1.Controls.Add(this.lstVideoDevices);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.panelVideoPreview);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.Uslikaj);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mt_z_pass2);
            this.groupBox1.Controls.Add(this.mt_z_pass1);
            this.groupBox1.Controls.Add(this.t_z_jmbg);
            this.groupBox1.Controls.Add(this.t_z_ime);
            this.groupBox1.Location = new System.Drawing.Point(11, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Potvrda Passworda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ime: ";
            // 
            // mt_z_pass2
            // 
            this.mt_z_pass2.Location = new System.Drawing.Point(112, 97);
            this.mt_z_pass2.Name = "mt_z_pass2";
            this.mt_z_pass2.PasswordChar = '%';
            this.mt_z_pass2.Size = new System.Drawing.Size(157, 20);
            this.mt_z_pass2.TabIndex = 30;
            // 
            // mt_z_pass1
            // 
            this.mt_z_pass1.Location = new System.Drawing.Point(64, 71);
            this.mt_z_pass1.Name = "mt_z_pass1";
            this.mt_z_pass1.PasswordChar = '%';
            this.mt_z_pass1.Size = new System.Drawing.Size(204, 20);
            this.mt_z_pass1.TabIndex = 29;
            // 
            // t_z_jmbg
            // 
            this.t_z_jmbg.Location = new System.Drawing.Point(65, 45);
            this.t_z_jmbg.Name = "t_z_jmbg";
            this.t_z_jmbg.Size = new System.Drawing.Size(203, 20);
            this.t_z_jmbg.TabIndex = 28;
            // 
            // t_z_ime
            // 
            this.t_z_ime.Location = new System.Drawing.Point(65, 19);
            this.t_z_ime.Name = "t_z_ime";
            this.t_z_ime.Size = new System.Drawing.Size(204, 20);
            this.t_z_ime.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // b_trazi
            // 
            this.b_trazi.Location = new System.Drawing.Point(220, 16);
            this.b_trazi.Name = "b_trazi";
            this.b_trazi.Size = new System.Drawing.Size(75, 23);
            this.b_trazi.TabIndex = 3;
            this.b_trazi.Text = "Traži";
            this.b_trazi.UseVisualStyleBackColor = true;
            this.b_trazi.Click += new System.EventHandler(this.b_trazi_Click);
            // 
            // lstAudioDevices
            // 
            this.lstAudioDevices.FormattingEnabled = true;
            this.lstAudioDevices.Location = new System.Drawing.Point(29, 354);
            this.lstAudioDevices.Name = "lstAudioDevices";
            this.lstAudioDevices.Size = new System.Drawing.Size(238, 43);
            this.lstAudioDevices.TabIndex = 41;
            this.lstAudioDevices.Visible = false;
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(29, 305);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(239, 43);
            this.lstVideoDevices.TabIndex = 40;
            this.lstVideoDevices.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Snimi Sliku";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelVideoPreview
            // 
            this.panelVideoPreview.Location = new System.Drawing.Point(275, 19);
            this.panelVideoPreview.Name = "panelVideoPreview";
            this.panelVideoPreview.Size = new System.Drawing.Size(500, 378);
            this.panelVideoPreview.TabIndex = 43;
            this.panelVideoPreview.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Prikaz";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Uslikaj
            // 
            this.Uslikaj.Location = new System.Drawing.Point(194, 247);
            this.Uslikaj.Name = "Uslikaj";
            this.Uslikaj.Size = new System.Drawing.Size(75, 23);
            this.Uslikaj.TabIndex = 39;
            this.Uslikaj.Text = "Uslikaj";
            this.Uslikaj.UseVisualStyleBackColor = true;
            this.Uslikaj.Click += new System.EventHandler(this.Uslikaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // UredjivanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 463);
            this.Controls.Add(this.b_trazi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UredjivanjeZaposlenika";
            this.Text = "Uređivanje Zaposlenika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UredjivanjeZaposlenika_FormClosing);
            this.Load += new System.EventHandler(this.UredjivanjeZaposlenika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mt_z_pass2;
        private System.Windows.Forms.MaskedTextBox mt_z_pass1;
        private System.Windows.Forms.TextBox t_z_jmbg;
        private System.Windows.Forms.TextBox t_z_ime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_trazi;
        private System.Windows.Forms.ListBox lstAudioDevices;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelVideoPreview;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Uslikaj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}