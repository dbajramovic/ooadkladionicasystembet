namespace GUI
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
            this.b_unos_d = new System.Windows.Forms.Button();
            this.b_stvaranje_t = new System.Windows.Forms.Button();
            this.b_registracija_c = new System.Windows.Forms.Button();
            this.b_registracija_z = new System.Windows.Forms.Button();
            this.b_izlaz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_unos_d
            // 
            this.b_unos_d.Location = new System.Drawing.Point(74, 12);
            this.b_unos_d.Name = "b_unos_d";
            this.b_unos_d.Size = new System.Drawing.Size(309, 48);
            this.b_unos_d.TabIndex = 0;
            this.b_unos_d.Text = "Unos Događaja";
            this.b_unos_d.UseVisualStyleBackColor = true;
            this.b_unos_d.Click += new System.EventHandler(this.b_unos_d_Click);
            // 
            // b_stvaranje_t
            // 
            this.b_stvaranje_t.Location = new System.Drawing.Point(74, 120);
            this.b_stvaranje_t.Name = "b_stvaranje_t";
            this.b_stvaranje_t.Size = new System.Drawing.Size(309, 46);
            this.b_stvaranje_t.TabIndex = 1;
            this.b_stvaranje_t.Text = "Stvaranje Tiketa";
            this.b_stvaranje_t.UseVisualStyleBackColor = true;
            this.b_stvaranje_t.Click += new System.EventHandler(this.b_stvaranje_t_Click);
            // 
            // b_registracija_c
            // 
            this.b_registracija_c.Location = new System.Drawing.Point(74, 172);
            this.b_registracija_c.Name = "b_registracija_c";
            this.b_registracija_c.Size = new System.Drawing.Size(309, 50);
            this.b_registracija_c.TabIndex = 2;
            this.b_registracija_c.Text = "Registracija Člana";
            this.b_registracija_c.UseVisualStyleBackColor = true;
            // 
            // b_registracija_z
            // 
            this.b_registracija_z.Location = new System.Drawing.Point(74, 228);
            this.b_registracija_z.Name = "b_registracija_z";
            this.b_registracija_z.Size = new System.Drawing.Size(309, 51);
            this.b_registracija_z.TabIndex = 3;
            this.b_registracija_z.Text = "Registracija Zaposlenika";
            this.b_registracija_z.UseVisualStyleBackColor = true;
            this.b_registracija_z.Click += new System.EventHandler(this.b_registracija_z_Click);
            // 
            // b_izlaz
            // 
            this.b_izlaz.Location = new System.Drawing.Point(74, 389);
            this.b_izlaz.Name = "b_izlaz";
            this.b_izlaz.Size = new System.Drawing.Size(309, 56);
            this.b_izlaz.TabIndex = 4;
            this.b_izlaz.Text = "Izlaz";
            this.b_izlaz.UseVisualStyleBackColor = true;
            this.b_izlaz.Click += new System.EventHandler(this.b_izlaz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Uređivanje Događaja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kviz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kviz - Unos Pitanja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_izlaz);
            this.Controls.Add(this.b_registracija_z);
            this.Controls.Add(this.b_registracija_c);
            this.Controls.Add(this.b_stvaranje_t);
            this.Controls.Add(this.b_unos_d);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SystemBet Kladionica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_unos_d;
        private System.Windows.Forms.Button b_stvaranje_t;
        private System.Windows.Forms.Button b_registracija_c;
        private System.Windows.Forms.Button b_registracija_z;
        private System.Windows.Forms.Button b_izlaz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

