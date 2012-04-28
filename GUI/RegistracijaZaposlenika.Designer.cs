namespace GUI
{
    partial class RegistracijaZaposlenika
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
            this.t_z_ime = new System.Windows.Forms.TextBox();
            this.t_z_prezime = new System.Windows.Forms.TextBox();
            this.t_z_jmbg = new System.Windows.Forms.TextBox();
            this.mt_z_pass1 = new System.Windows.Forms.MaskedTextBox();
            this.mt_z_pass2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_z_ime
            // 
            this.t_z_ime.Location = new System.Drawing.Point(72, 12);
            this.t_z_ime.Name = "t_z_ime";
            this.t_z_ime.Size = new System.Drawing.Size(204, 20);
            this.t_z_ime.TabIndex = 0;
            // 
            // t_z_prezime
            // 
            this.t_z_prezime.Location = new System.Drawing.Point(72, 38);
            this.t_z_prezime.Name = "t_z_prezime";
            this.t_z_prezime.Size = new System.Drawing.Size(204, 20);
            this.t_z_prezime.TabIndex = 1;
            // 
            // t_z_jmbg
            // 
            this.t_z_jmbg.Location = new System.Drawing.Point(73, 64);
            this.t_z_jmbg.Name = "t_z_jmbg";
            this.t_z_jmbg.Size = new System.Drawing.Size(203, 20);
            this.t_z_jmbg.TabIndex = 2;
            // 
            // mt_z_pass1
            // 
            this.mt_z_pass1.Location = new System.Drawing.Point(73, 90);
            this.mt_z_pass1.Name = "mt_z_pass1";
            this.mt_z_pass1.Size = new System.Drawing.Size(204, 20);
            this.mt_z_pass1.TabIndex = 4;
            // 
            // mt_z_pass2
            // 
            this.mt_z_pass2.Location = new System.Drawing.Point(126, 116);
            this.mt_z_pass2.Name = "mt_z_pass2";
            this.mt_z_pass2.Size = new System.Drawing.Size(150, 20);
            this.mt_z_pass2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Potvrda Passworda:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistracijaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 173);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mt_z_pass2);
            this.Controls.Add(this.mt_z_pass1);
            this.Controls.Add(this.t_z_jmbg);
            this.Controls.Add(this.t_z_prezime);
            this.Controls.Add(this.t_z_ime);
            this.Name = "RegistracijaZaposlenika";
            this.Text = "Registracija Zaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_z_ime;
        private System.Windows.Forms.TextBox t_z_prezime;
        private System.Windows.Forms.TextBox t_z_jmbg;
        private System.Windows.Forms.MaskedTextBox mt_z_pass1;
        private System.Windows.Forms.MaskedTextBox mt_z_pass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}