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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.događajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.događajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.osobuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.članaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provjeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobitkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printajPonuduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiProdajuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printajPonuduToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.provjeraToolStripMenuItem,
            this.printajPonuduToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izađiToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.programToolStripMenuItem.Text = "Program...";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.događajToolStripMenuItem,
            this.tiketToolStripMenuItem,
            this.osobuToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj...";
            // 
            // događajToolStripMenuItem
            // 
            this.događajToolStripMenuItem.Name = "događajToolStripMenuItem";
            this.događajToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.događajToolStripMenuItem.Text = "Događaj";
            this.događajToolStripMenuItem.Click += new System.EventHandler(this.događajToolStripMenuItem_Click);
            // 
            // tiketToolStripMenuItem
            // 
            this.tiketToolStripMenuItem.Name = "tiketToolStripMenuItem";
            this.tiketToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.tiketToolStripMenuItem.Text = "Tiket";
            this.tiketToolStripMenuItem.Click += new System.EventHandler(this.tiketToolStripMenuItem_Click);
            // 
            // osobuToolStripMenuItem
            // 
            this.osobuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članaToolStripMenuItem,
            this.uposlenikaToolStripMenuItem});
            this.osobuToolStripMenuItem.Name = "osobuToolStripMenuItem";
            this.osobuToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.osobuToolStripMenuItem.Text = "Osobu";
            // 
            // članaToolStripMenuItem
            // 
            this.članaToolStripMenuItem.Name = "članaToolStripMenuItem";
            this.članaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.članaToolStripMenuItem.Text = "Člana";
            this.članaToolStripMenuItem.Click += new System.EventHandler(this.članaToolStripMenuItem_Click);
            // 
            // uposlenikaToolStripMenuItem
            // 
            this.uposlenikaToolStripMenuItem.Name = "uposlenikaToolStripMenuItem";
            this.uposlenikaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.uposlenikaToolStripMenuItem.Text = "Uposlenika";
            this.uposlenikaToolStripMenuItem.Click += new System.EventHandler(this.uposlenikaToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.događajToolStripMenuItem1,
            this.osobuToolStripMenuItem1});
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.urediToolStripMenuItem.Text = "Uredi...";
            // 
            // događajToolStripMenuItem1
            // 
            this.događajToolStripMenuItem1.Name = "događajToolStripMenuItem1";
            this.događajToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.događajToolStripMenuItem1.Text = "Događaj";
            this.događajToolStripMenuItem1.Click += new System.EventHandler(this.događajToolStripMenuItem1_Click);
            // 
            // osobuToolStripMenuItem1
            // 
            this.osobuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članaToolStripMenuItem1,
            this.uposlenikToolStripMenuItem});
            this.osobuToolStripMenuItem1.Name = "osobuToolStripMenuItem1";
            this.osobuToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.osobuToolStripMenuItem1.Text = "Osobu";
            // 
            // članaToolStripMenuItem1
            // 
            this.članaToolStripMenuItem1.Name = "članaToolStripMenuItem1";
            this.članaToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.članaToolStripMenuItem1.Text = "Člana";
            this.članaToolStripMenuItem1.Click += new System.EventHandler(this.članaToolStripMenuItem1_Click);
            // 
            // uposlenikToolStripMenuItem
            // 
            this.uposlenikToolStripMenuItem.Name = "uposlenikToolStripMenuItem";
            this.uposlenikToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.uposlenikToolStripMenuItem.Text = "Uposlenik";
            this.uposlenikToolStripMenuItem.Click += new System.EventHandler(this.uposlenikToolStripMenuItem_Click);
            // 
            // provjeraToolStripMenuItem
            // 
            this.provjeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobitkaToolStripMenuItem});
            this.provjeraToolStripMenuItem.Name = "provjeraToolStripMenuItem";
            this.provjeraToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.provjeraToolStripMenuItem.Text = "Provjera...";
            this.provjeraToolStripMenuItem.Click += new System.EventHandler(this.provjeraToolStripMenuItem_Click);
            // 
            // dobitkaToolStripMenuItem
            // 
            this.dobitkaToolStripMenuItem.Name = "dobitkaToolStripMenuItem";
            this.dobitkaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.dobitkaToolStripMenuItem.Text = "Dobitka";
            this.dobitkaToolStripMenuItem.Click += new System.EventHandler(this.dobitkaToolStripMenuItem_Click);
            // 
            // printajPonuduToolStripMenuItem
            // 
            this.printajPonuduToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiProdajuToolStripMenuItem,
            this.printajPonuduToolStripMenuItem1});
            this.printajPonuduToolStripMenuItem.Name = "printajPonuduToolStripMenuItem";
            this.printajPonuduToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.printajPonuduToolStripMenuItem.Text = "Ponuda...";
            this.printajPonuduToolStripMenuItem.Click += new System.EventHandler(this.printajPonuduToolStripMenuItem_Click);
            // 
            // snimiProdajuToolStripMenuItem
            // 
            this.snimiProdajuToolStripMenuItem.Name = "snimiProdajuToolStripMenuItem";
            this.snimiProdajuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.snimiProdajuToolStripMenuItem.Text = "Snimi Prodaju";
            this.snimiProdajuToolStripMenuItem.Click += new System.EventHandler(this.snimiProdajuToolStripMenuItem_Click);
            // 
            // printajPonuduToolStripMenuItem1
            // 
            this.printajPonuduToolStripMenuItem1.Name = "printajPonuduToolStripMenuItem1";
            this.printajPonuduToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.printajPonuduToolStripMenuItem1.Text = "Printaj Ponudu";
            this.printajPonuduToolStripMenuItem1.Click += new System.EventHandler(this.printajPonuduToolStripMenuItem1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 279);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SystemBet Kladionica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provjeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem događajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem događajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem osobuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem članaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobitkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printajPonuduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiProdajuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printajPonuduToolStripMenuItem1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

