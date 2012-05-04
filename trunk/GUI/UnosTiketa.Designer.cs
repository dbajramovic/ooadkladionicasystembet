namespace GUI
{
    partial class UnosTiketa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.t_pretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_pretraga = new System.Windows.Forms.Button();
            this.c_clan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 99);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b_dodaj
            // 
            this.b_dodaj.Location = new System.Drawing.Point(704, 2);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(156, 23);
            this.b_dodaj.TabIndex = 6;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(841, 197);
            this.dataGridView2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stvori Tiket";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // t_pretraga
            // 
            this.t_pretraga.Location = new System.Drawing.Point(45, 5);
            this.t_pretraga.Name = "t_pretraga";
            this.t_pretraga.Size = new System.Drawing.Size(100, 20);
            this.t_pretraga.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID :";
            // 
            // b_pretraga
            // 
            this.b_pretraga.Location = new System.Drawing.Point(151, 5);
            this.b_pretraga.Name = "b_pretraga";
            this.b_pretraga.Size = new System.Drawing.Size(98, 23);
            this.b_pretraga.TabIndex = 12;
            this.b_pretraga.Text = "Traži po ID-u";
            this.b_pretraga.UseVisualStyleBackColor = true;
            this.b_pretraga.Click += new System.EventHandler(this.b_pretraga_Click);
            // 
            // c_clan
            // 
            this.c_clan.AutoSize = true;
            this.c_clan.Location = new System.Drawing.Point(651, 6);
            this.c_clan.Name = "c_clan";
            this.c_clan.Size = new System.Drawing.Size(47, 17);
            this.c_clan.TabIndex = 13;
            this.c_clan.Text = "Član";
            this.c_clan.UseVisualStyleBackColor = true;
            this.c_clan.CheckedChanged += new System.EventHandler(this.c_clan_CheckedChanged);
            // 
            // UnosTiketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 398);
            this.Controls.Add(this.c_clan);
            this.Controls.Add(this.b_pretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_pretraga);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.b_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UnosTiketa";
            this.Text = "Unos Tiketa";
            this.Load += new System.EventHandler(this.UnosTiketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDogadjajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvotaXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota1XDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvotaX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota12DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox t_pretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_pretraga;
        private System.Windows.Forms.CheckBox c_clan;
    }
}