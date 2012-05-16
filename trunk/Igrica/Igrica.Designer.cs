namespace Ball_Escape
{
    partial class Igrica
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
            this.components = new System.ComponentModel.Container();
            this.b_izaberi_nivo = new System.Windows.Forms.Button();
            this.b_nova_igra = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmrLBLRefresher = new System.Windows.Forms.Timer(this.components);
            this.lblBTNDgnstcs = new System.Windows.Forms.Label();
            this.tmrBallMovement = new System.Windows.Forms.Timer(this.components);
            this.lblClear = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblComplete = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLvl1 = new System.Windows.Forms.Button();
            this.btnLvl2 = new System.Windows.Forms.Button();
            this.btnLvl4 = new System.Windows.Forms.Button();
            this.btnLvl3 = new System.Windows.Forms.Button();
            this.btnLvl5 = new System.Windows.Forms.Button();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.btnLvl6 = new System.Windows.Forms.Button();
            this.btnLvl12 = new System.Windows.Forms.Button();
            this.btnLvl11 = new System.Windows.Forms.Button();
            this.btnLvl10 = new System.Windows.Forms.Button();
            this.btnLvl9 = new System.Windows.Forms.Button();
            this.btnLvl8 = new System.Windows.Forms.Button();
            this.btnLvl7 = new System.Windows.Forms.Button();
            this.btnLvl18 = new System.Windows.Forms.Button();
            this.btnLvl17 = new System.Windows.Forms.Button();
            this.btnLvl16 = new System.Windows.Forms.Button();
            this.btnLvl15 = new System.Windows.Forms.Button();
            this.btnLvl14 = new System.Windows.Forms.Button();
            this.btnLvl13 = new System.Windows.Forms.Button();
            this.b_sljedeci_nivo = new System.Windows.Forms.Button();
            this.timerObrni = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // b_izaberi_nivo
            // 
            this.b_izaberi_nivo.BackColor = System.Drawing.SystemColors.WindowText;
            this.b_izaberi_nivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_izaberi_nivo.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_izaberi_nivo.Location = new System.Drawing.Point(330, 467);
            this.b_izaberi_nivo.Name = "b_izaberi_nivo";
            this.b_izaberi_nivo.Size = new System.Drawing.Size(300, 92);
            this.b_izaberi_nivo.TabIndex = 3;
            this.b_izaberi_nivo.TabStop = false;
            this.b_izaberi_nivo.Text = "Izaberi Nivo";
            this.b_izaberi_nivo.UseVisualStyleBackColor = false;
            this.b_izaberi_nivo.Click += new System.EventHandler(this.btnSelectLevels_Click);
            // 
            // b_nova_igra
            // 
            this.b_nova_igra.BackColor = System.Drawing.SystemColors.WindowText;
            this.b_nova_igra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_nova_igra.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_nova_igra.Location = new System.Drawing.Point(330, 169);
            this.b_nova_igra.Name = "b_nova_igra";
            this.b_nova_igra.Size = new System.Drawing.Size(300, 92);
            this.b_nova_igra.TabIndex = 2;
            this.b_nova_igra.TabStop = false;
            this.b_nova_igra.Text = "Nova Igra";
            this.b_nova_igra.UseVisualStyleBackColor = false;
            this.b_nova_igra.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Interval = 1;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // tmrLBLRefresher
            // 
            this.tmrLBLRefresher.Interval = 1;
            this.tmrLBLRefresher.Tick += new System.EventHandler(this.tmrLBLRefresher_Tick);
            // 
            // lblBTNDgnstcs
            // 
            this.lblBTNDgnstcs.AutoSize = true;
            this.lblBTNDgnstcs.Location = new System.Drawing.Point(13, 615);
            this.lblBTNDgnstcs.Name = "lblBTNDgnstcs";
            this.lblBTNDgnstcs.Size = new System.Drawing.Size(0, 13);
            this.lblBTNDgnstcs.TabIndex = 4;
            this.lblBTNDgnstcs.Visible = false;
            // 
            // tmrBallMovement
            // 
            this.tmrBallMovement.Interval = 1;
            this.tmrBallMovement.Tick += new System.EventHandler(this.tmrBallMovement_Tick);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(269, 90);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(437, 76);
            this.lblClear.TabIndex = 6;
            this.lblClear.Text = "Nivo 1 Gotov!";
            this.lblClear.Visible = false;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(330, 300);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(300, 92);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Sljedeci Nivo";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.Location = new System.Drawing.Point(269, 181);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(437, 76);
            this.lblComplete.TabIndex = 8;
            this.lblComplete.Text = "Nivo 1 Gotov!";
            this.lblComplete.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLvl1
            // 
            this.btnLvl1.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl1.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl1.Location = new System.Drawing.Point(75, 12);
            this.btnLvl1.Name = "btnLvl1";
            this.btnLvl1.Size = new System.Drawing.Size(90, 62);
            this.btnLvl1.TabIndex = 9;
            this.btnLvl1.TabStop = false;
            this.btnLvl1.Text = "1";
            this.btnLvl1.UseVisualStyleBackColor = false;
            this.btnLvl1.Visible = false;
            this.btnLvl1.Click += new System.EventHandler(this.btnLvl1_Click);
            // 
            // btnLvl2
            // 
            this.btnLvl2.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl2.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl2.Location = new System.Drawing.Point(218, 12);
            this.btnLvl2.Name = "btnLvl2";
            this.btnLvl2.Size = new System.Drawing.Size(90, 62);
            this.btnLvl2.TabIndex = 10;
            this.btnLvl2.TabStop = false;
            this.btnLvl2.Text = "2";
            this.btnLvl2.UseVisualStyleBackColor = false;
            this.btnLvl2.Visible = false;
            this.btnLvl2.Click += new System.EventHandler(this.btnLvl2_Click);
            // 
            // btnLvl4
            // 
            this.btnLvl4.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl4.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl4.Location = new System.Drawing.Point(510, 12);
            this.btnLvl4.Name = "btnLvl4";
            this.btnLvl4.Size = new System.Drawing.Size(90, 62);
            this.btnLvl4.TabIndex = 12;
            this.btnLvl4.TabStop = false;
            this.btnLvl4.Text = "4";
            this.btnLvl4.UseVisualStyleBackColor = false;
            this.btnLvl4.Visible = false;
            this.btnLvl4.Click += new System.EventHandler(this.btnLvl4_Click);
            // 
            // btnLvl3
            // 
            this.btnLvl3.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl3.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl3.Location = new System.Drawing.Point(361, 12);
            this.btnLvl3.Name = "btnLvl3";
            this.btnLvl3.Size = new System.Drawing.Size(90, 62);
            this.btnLvl3.TabIndex = 11;
            this.btnLvl3.TabStop = false;
            this.btnLvl3.Text = "3";
            this.btnLvl3.UseVisualStyleBackColor = false;
            this.btnLvl3.Visible = false;
            this.btnLvl3.Click += new System.EventHandler(this.btnLvl3_Click);
            // 
            // btnLvl5
            // 
            this.btnLvl5.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl5.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl5.Location = new System.Drawing.Point(653, 12);
            this.btnLvl5.Name = "btnLvl5";
            this.btnLvl5.Size = new System.Drawing.Size(90, 62);
            this.btnLvl5.TabIndex = 13;
            this.btnLvl5.TabStop = false;
            this.btnLvl5.Text = "5";
            this.btnLvl5.UseVisualStyleBackColor = false;
            this.btnLvl5.Visible = false;
            this.btnLvl5.Click += new System.EventHandler(this.btnLvl5_Click);
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = global::Ball_Escape.Properties.Resources.Ball;
            this.pbBall.Location = new System.Drawing.Point(928, 3);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(20, 20);
            this.pbBall.TabIndex = 5;
            this.pbBall.TabStop = false;
            this.pbBall.Visible = false;
            // 
            // btnLvl6
            // 
            this.btnLvl6.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl6.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl6.Location = new System.Drawing.Point(796, 12);
            this.btnLvl6.Name = "btnLvl6";
            this.btnLvl6.Size = new System.Drawing.Size(90, 62);
            this.btnLvl6.TabIndex = 14;
            this.btnLvl6.TabStop = false;
            this.btnLvl6.Text = "6";
            this.btnLvl6.UseVisualStyleBackColor = false;
            this.btnLvl6.Visible = false;
            this.btnLvl6.Click += new System.EventHandler(this.btnLvl6_Click);
            // 
            // btnLvl12
            // 
            this.btnLvl12.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl12.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl12.Location = new System.Drawing.Point(796, 148);
            this.btnLvl12.Name = "btnLvl12";
            this.btnLvl12.Size = new System.Drawing.Size(90, 62);
            this.btnLvl12.TabIndex = 20;
            this.btnLvl12.TabStop = false;
            this.btnLvl12.Text = "12";
            this.btnLvl12.UseVisualStyleBackColor = false;
            this.btnLvl12.Visible = false;
            this.btnLvl12.Click += new System.EventHandler(this.btnLvl12_Click);
            // 
            // btnLvl11
            // 
            this.btnLvl11.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl11.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl11.Location = new System.Drawing.Point(653, 148);
            this.btnLvl11.Name = "btnLvl11";
            this.btnLvl11.Size = new System.Drawing.Size(90, 62);
            this.btnLvl11.TabIndex = 19;
            this.btnLvl11.TabStop = false;
            this.btnLvl11.Text = "11";
            this.btnLvl11.UseVisualStyleBackColor = false;
            this.btnLvl11.Visible = false;
            this.btnLvl11.Click += new System.EventHandler(this.btnLvl11_Click);
            // 
            // btnLvl10
            // 
            this.btnLvl10.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl10.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl10.Location = new System.Drawing.Point(510, 148);
            this.btnLvl10.Name = "btnLvl10";
            this.btnLvl10.Size = new System.Drawing.Size(90, 62);
            this.btnLvl10.TabIndex = 18;
            this.btnLvl10.TabStop = false;
            this.btnLvl10.Text = "10";
            this.btnLvl10.UseVisualStyleBackColor = false;
            this.btnLvl10.Visible = false;
            this.btnLvl10.Click += new System.EventHandler(this.btnLvl10_Click);
            // 
            // btnLvl9
            // 
            this.btnLvl9.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl9.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl9.Location = new System.Drawing.Point(361, 148);
            this.btnLvl9.Name = "btnLvl9";
            this.btnLvl9.Size = new System.Drawing.Size(90, 62);
            this.btnLvl9.TabIndex = 17;
            this.btnLvl9.TabStop = false;
            this.btnLvl9.Text = "9";
            this.btnLvl9.UseVisualStyleBackColor = false;
            this.btnLvl9.Visible = false;
            this.btnLvl9.Click += new System.EventHandler(this.btnLvl9_Click);
            // 
            // btnLvl8
            // 
            this.btnLvl8.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl8.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl8.Location = new System.Drawing.Point(218, 148);
            this.btnLvl8.Name = "btnLvl8";
            this.btnLvl8.Size = new System.Drawing.Size(90, 62);
            this.btnLvl8.TabIndex = 16;
            this.btnLvl8.TabStop = false;
            this.btnLvl8.Text = "8";
            this.btnLvl8.UseVisualStyleBackColor = false;
            this.btnLvl8.Visible = false;
            this.btnLvl8.Click += new System.EventHandler(this.btnLvl8_Click);
            // 
            // btnLvl7
            // 
            this.btnLvl7.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl7.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl7.Location = new System.Drawing.Point(75, 148);
            this.btnLvl7.Name = "btnLvl7";
            this.btnLvl7.Size = new System.Drawing.Size(90, 62);
            this.btnLvl7.TabIndex = 15;
            this.btnLvl7.TabStop = false;
            this.btnLvl7.Text = "7";
            this.btnLvl7.UseVisualStyleBackColor = false;
            this.btnLvl7.Visible = false;
            this.btnLvl7.Click += new System.EventHandler(this.btnLvl7_Click);
            // 
            // btnLvl18
            // 
            this.btnLvl18.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl18.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl18.Location = new System.Drawing.Point(796, 284);
            this.btnLvl18.Name = "btnLvl18";
            this.btnLvl18.Size = new System.Drawing.Size(90, 62);
            this.btnLvl18.TabIndex = 26;
            this.btnLvl18.TabStop = false;
            this.btnLvl18.Text = "18";
            this.btnLvl18.UseVisualStyleBackColor = false;
            this.btnLvl18.Visible = false;
            this.btnLvl18.Click += new System.EventHandler(this.btnLvl18_Click);
            // 
            // btnLvl17
            // 
            this.btnLvl17.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl17.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl17.Location = new System.Drawing.Point(653, 284);
            this.btnLvl17.Name = "btnLvl17";
            this.btnLvl17.Size = new System.Drawing.Size(90, 62);
            this.btnLvl17.TabIndex = 25;
            this.btnLvl17.TabStop = false;
            this.btnLvl17.Text = "17";
            this.btnLvl17.UseVisualStyleBackColor = false;
            this.btnLvl17.Visible = false;
            this.btnLvl17.Click += new System.EventHandler(this.btnLvl17_Click);
            // 
            // btnLvl16
            // 
            this.btnLvl16.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl16.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl16.Location = new System.Drawing.Point(510, 284);
            this.btnLvl16.Name = "btnLvl16";
            this.btnLvl16.Size = new System.Drawing.Size(90, 62);
            this.btnLvl16.TabIndex = 24;
            this.btnLvl16.TabStop = false;
            this.btnLvl16.Text = "16";
            this.btnLvl16.UseVisualStyleBackColor = false;
            this.btnLvl16.Visible = false;
            this.btnLvl16.Click += new System.EventHandler(this.btnLvl16_Click);
            // 
            // btnLvl15
            // 
            this.btnLvl15.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl15.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl15.Location = new System.Drawing.Point(361, 284);
            this.btnLvl15.Name = "btnLvl15";
            this.btnLvl15.Size = new System.Drawing.Size(90, 62);
            this.btnLvl15.TabIndex = 23;
            this.btnLvl15.TabStop = false;
            this.btnLvl15.Text = "15";
            this.btnLvl15.UseVisualStyleBackColor = false;
            this.btnLvl15.Visible = false;
            this.btnLvl15.Click += new System.EventHandler(this.btnLvl15_Click);
            // 
            // btnLvl14
            // 
            this.btnLvl14.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl14.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl14.Location = new System.Drawing.Point(218, 284);
            this.btnLvl14.Name = "btnLvl14";
            this.btnLvl14.Size = new System.Drawing.Size(90, 62);
            this.btnLvl14.TabIndex = 22;
            this.btnLvl14.TabStop = false;
            this.btnLvl14.Text = "14";
            this.btnLvl14.UseVisualStyleBackColor = false;
            this.btnLvl14.Visible = false;
            this.btnLvl14.Click += new System.EventHandler(this.btnLvl14_Click);
            // 
            // btnLvl13
            // 
            this.btnLvl13.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLvl13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLvl13.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl13.Location = new System.Drawing.Point(75, 284);
            this.btnLvl13.Name = "btnLvl13";
            this.btnLvl13.Size = new System.Drawing.Size(90, 62);
            this.btnLvl13.TabIndex = 21;
            this.btnLvl13.TabStop = false;
            this.btnLvl13.Text = "13";
            this.btnLvl13.UseVisualStyleBackColor = false;
            this.btnLvl13.Visible = false;
            this.btnLvl13.Click += new System.EventHandler(this.btnLvl13_Click);
            // 
            // b_sljedeci_nivo
            // 
            this.b_sljedeci_nivo.BackColor = System.Drawing.SystemColors.WindowText;
            this.b_sljedeci_nivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_sljedeci_nivo.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sljedeci_nivo.Location = new System.Drawing.Point(330, 300);
            this.b_sljedeci_nivo.Name = "b_sljedeci_nivo";
            this.b_sljedeci_nivo.Size = new System.Drawing.Size(300, 92);
            this.b_sljedeci_nivo.TabIndex = 27;
            this.b_sljedeci_nivo.TabStop = false;
            this.b_sljedeci_nivo.Text = "Sljedeci Nivo";
            this.b_sljedeci_nivo.UseVisualStyleBackColor = false;
            this.b_sljedeci_nivo.Visible = false;
            // 
            // timerObrni
            // 
            this.timerObrni.Interval = 500;
            this.timerObrni.Tick += new System.EventHandler(this.timerObrni_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "FLIPED!";
            this.label1.Visible = false;
            // 
            // Igrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_sljedeci_nivo);
            this.Controls.Add(this.btnLvl18);
            this.Controls.Add(this.btnLvl17);
            this.Controls.Add(this.btnLvl16);
            this.Controls.Add(this.btnLvl15);
            this.Controls.Add(this.btnLvl14);
            this.Controls.Add(this.btnLvl13);
            this.Controls.Add(this.btnLvl12);
            this.Controls.Add(this.btnLvl11);
            this.Controls.Add(this.btnLvl10);
            this.Controls.Add(this.btnLvl9);
            this.Controls.Add(this.btnLvl8);
            this.Controls.Add(this.btnLvl7);
            this.Controls.Add(this.btnLvl6);
            this.Controls.Add(this.btnLvl5);
            this.Controls.Add(this.btnLvl4);
            this.Controls.Add(this.btnLvl3);
            this.Controls.Add(this.btnLvl2);
            this.Controls.Add(this.btnLvl1);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.lblBTNDgnstcs);
            this.Controls.Add(this.b_izaberi_nivo);
            this.Controls.Add(this.b_nova_igra);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Igrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_nova_igra;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Button b_izaberi_nivo;
        private System.Windows.Forms.Timer tmrLBLRefresher;
        private System.Windows.Forms.Label lblBTNDgnstcs;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer tmrBallMovement;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLvl1;
        private System.Windows.Forms.Button btnLvl2;
        private System.Windows.Forms.Button btnLvl4;
        private System.Windows.Forms.Button btnLvl3;
        private System.Windows.Forms.Button btnLvl5;
        private System.Windows.Forms.Button btnLvl6;
        private System.Windows.Forms.Button btnLvl12;
        private System.Windows.Forms.Button btnLvl11;
        private System.Windows.Forms.Button btnLvl10;
        private System.Windows.Forms.Button btnLvl9;
        private System.Windows.Forms.Button btnLvl8;
        private System.Windows.Forms.Button btnLvl7;
        private System.Windows.Forms.Button btnLvl18;
        private System.Windows.Forms.Button btnLvl17;
        private System.Windows.Forms.Button btnLvl16;
        private System.Windows.Forms.Button btnLvl15;
        private System.Windows.Forms.Button btnLvl14;
        private System.Windows.Forms.Button btnLvl13;
        private System.Windows.Forms.Button b_sljedeci_nivo;
        private System.Windows.Forms.Timer timerObrni;
        private System.Windows.Forms.Label label1;
    }
}

