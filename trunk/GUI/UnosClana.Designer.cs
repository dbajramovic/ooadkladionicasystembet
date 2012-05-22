namespace GUI
{
    partial class UnosClana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosClana));
            this.t_ime = new System.Windows.Forms.TextBox();
            this.t_prezime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_jmbg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelVideoPreview = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lstAudioDevices = new System.Windows.Forms.ListBox();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.Uslikaj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_ime
            // 
            this.t_ime.Location = new System.Drawing.Point(64, 15);
            this.t_ime.Name = "t_ime";
            this.t_ime.Size = new System.Drawing.Size(237, 20);
            this.t_ime.TabIndex = 0;
            // 
            // t_prezime
            // 
            this.t_prezime.Location = new System.Drawing.Point(64, 41);
            this.t_prezime.Name = "t_prezime";
            this.t_prezime.Size = new System.Drawing.Size(237, 20);
            this.t_prezime.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Poništi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime :";
            // 
            // t_jmbg
            // 
            this.t_jmbg.Location = new System.Drawing.Point(64, 67);
            this.t_jmbg.Name = "t_jmbg";
            this.t_jmbg.Size = new System.Drawing.Size(237, 20);
            this.t_jmbg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "JMBG :";
            // 
            // panelVideoPreview
            // 
            this.panelVideoPreview.Location = new System.Drawing.Point(307, 9);
            this.panelVideoPreview.Name = "panelVideoPreview";
            this.panelVideoPreview.Size = new System.Drawing.Size(327, 264);
            this.panelVideoPreview.TabIndex = 24;
            this.panelVideoPreview.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Prikaz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstAudioDevices
            // 
            this.lstAudioDevices.FormattingEnabled = true;
            this.lstAudioDevices.Location = new System.Drawing.Point(62, 176);
            this.lstAudioDevices.Name = "lstAudioDevices";
            this.lstAudioDevices.Size = new System.Drawing.Size(238, 43);
            this.lstAudioDevices.TabIndex = 22;
            this.lstAudioDevices.Visible = false;
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(62, 127);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(239, 43);
            this.lstVideoDevices.TabIndex = 21;
            this.lstVideoDevices.Visible = false;
            // 
            // Uslikaj
            // 
            this.Uslikaj.Location = new System.Drawing.Point(64, 98);
            this.Uslikaj.Name = "Uslikaj";
            this.Uslikaj.Size = new System.Drawing.Size(75, 23);
            this.Uslikaj.TabIndex = 20;
            this.Uslikaj.Text = "Uslikaj";
            this.Uslikaj.UseVisualStyleBackColor = true;
            this.Uslikaj.Click += new System.EventHandler(this.Uslikaj_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Snimi Sliku";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // UnosClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelVideoPreview);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lstAudioDevices);
            this.Controls.Add(this.lstVideoDevices);
            this.Controls.Add(this.Uslikaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_jmbg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_prezime);
            this.Controls.Add(this.t_ime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosClana";
            this.Text = "Unos Člana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnosClana_FormClosing);
            this.Load += new System.EventHandler(this.UnosClana_Load);
            this.Enter += new System.EventHandler(this.UnosClana_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_ime;
        private System.Windows.Forms.TextBox t_prezime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_jmbg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelVideoPreview;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstAudioDevices;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.Button Uslikaj;
        private System.Windows.Forms.Button button3;
    }
}