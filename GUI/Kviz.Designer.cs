namespace GUI
{
    partial class Kviz
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.r_a = new System.Windows.Forms.RadioButton();
            this.r_b = new System.Windows.Forms.RadioButton();
            this.r_c = new System.Windows.Forms.RadioButton();
            this.r_d = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_br_bodova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 63);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // r_a
            // 
            this.r_a.AutoSize = true;
            this.r_a.Location = new System.Drawing.Point(20, 83);
            this.r_a.Name = "r_a";
            this.r_a.Size = new System.Drawing.Size(85, 17);
            this.r_a.TabIndex = 1;
            this.r_a.TabStop = true;
            this.r_a.Text = "radioButton1";
            this.r_a.UseVisualStyleBackColor = true;
            // 
            // r_b
            // 
            this.r_b.AutoSize = true;
            this.r_b.Location = new System.Drawing.Point(20, 106);
            this.r_b.Name = "r_b";
            this.r_b.Size = new System.Drawing.Size(85, 17);
            this.r_b.TabIndex = 2;
            this.r_b.TabStop = true;
            this.r_b.Text = "radioButton2";
            this.r_b.UseVisualStyleBackColor = true;
            // 
            // r_c
            // 
            this.r_c.AutoSize = true;
            this.r_c.Location = new System.Drawing.Point(20, 129);
            this.r_c.Name = "r_c";
            this.r_c.Size = new System.Drawing.Size(85, 17);
            this.r_c.TabIndex = 3;
            this.r_c.TabStop = true;
            this.r_c.Text = "radioButton3";
            this.r_c.UseVisualStyleBackColor = true;
            // 
            // r_d
            // 
            this.r_d.AutoSize = true;
            this.r_d.Location = new System.Drawing.Point(20, 152);
            this.r_d.Name = "r_d";
            this.r_d.Size = new System.Drawing.Size(85, 17);
            this.r_d.TabIndex = 4;
            this.r_d.TabStop = true;
            this.r_d.Text = "radioButton4";
            this.r_d.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Odustajem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Broj Bodova :";
            // 
            // l_br_bodova
            // 
            this.l_br_bodova.AutoSize = true;
            this.l_br_bodova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_br_bodova.Location = new System.Drawing.Point(376, 106);
            this.l_br_bodova.Name = "l_br_bodova";
            this.l_br_bodova.Size = new System.Drawing.Size(70, 25);
            this.l_br_bodova.TabIndex = 8;
            this.l_br_bodova.Text = "label2";
            // 
            // Kviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 215);
            this.Controls.Add(this.l_br_bodova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r_d);
            this.Controls.Add(this.r_c);
            this.Controls.Add(this.r_b);
            this.Controls.Add(this.r_a);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Kviz";
            this.Text = "Kviz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton r_a;
        private System.Windows.Forms.RadioButton r_b;
        private System.Windows.Forms.RadioButton r_c;
        private System.Windows.Forms.RadioButton r_d;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_br_bodova;
    }
}

