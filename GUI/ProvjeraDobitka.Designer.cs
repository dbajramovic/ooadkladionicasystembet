﻿namespace GUI
{
    partial class ProvjeraDobitka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvjeraDobitka));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g_izvjestaj = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l_je_li_dobitni = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.g_izvjestaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tiketa :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 223);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // g_izvjestaj
            // 
            this.g_izvjestaj.Controls.Add(this.button1);
            this.g_izvjestaj.Controls.Add(this.l_je_li_dobitni);
            this.g_izvjestaj.Location = new System.Drawing.Point(16, 265);
            this.g_izvjestaj.Name = "g_izvjestaj";
            this.g_izvjestaj.Size = new System.Drawing.Size(785, 55);
            this.g_izvjestaj.TabIndex = 4;
            this.g_izvjestaj.TabStop = false;
            this.g_izvjestaj.Text = "Izvještaj";
            this.g_izvjestaj.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_je_li_dobitni
            // 
            this.l_je_li_dobitni.AutoSize = true;
            this.l_je_li_dobitni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_je_li_dobitni.Location = new System.Drawing.Point(6, 19);
            this.l_je_li_dobitni.Name = "l_je_li_dobitni";
            this.l_je_li_dobitni.Size = new System.Drawing.Size(60, 24);
            this.l_je_li_dobitni.TabIndex = 0;
            this.l_je_li_dobitni.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Uredi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProvjeraDobitka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.g_izvjestaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProvjeraDobitka";
            this.Text = "Provjera Dobitka";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.g_izvjestaj.ResumeLayout(false);
            this.g_izvjestaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox g_izvjestaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_je_li_dobitni;
        private System.Windows.Forms.Button button2;
    }
}