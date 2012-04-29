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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imePUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvotaXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvota1XDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvotaX2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvota12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satnicaOdrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDogadjajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadjajiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kladionicaDataSet = new GUI.kladionicaDataSet();
            this.dogadjajiTableAdapter = new GUI.kladionicaDataSetTableAdapters.dogadjajiTableAdapter();
            this.fillByIdToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadjajiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kladionicaDataSet)).BeginInit();
            this.fillByIdToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePUDataGridViewTextBoxColumn,
            this.imeDUDataGridViewTextBoxColumn,
            this.kvota1DataGridViewTextBoxColumn,
            this.kvotaXDataGridViewTextBoxColumn,
            this.kvota2DataGridViewTextBoxColumn,
            this.kvota1XDataGridViewTextBoxColumn,
            this.kvotaX2DataGridViewTextBoxColumn,
            this.kvota12DataGridViewTextBoxColumn,
            this.rezultatDataGridViewTextBoxColumn,
            this.datumOdrzavanjaDataGridViewTextBoxColumn,
            this.satnicaOdrzavanjaDataGridViewTextBoxColumn,
            this.idDogadjajaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dogadjajiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 99);
            this.dataGridView1.TabIndex = 3;
            // 
            // imePUDataGridViewTextBoxColumn
            // 
            this.imePUDataGridViewTextBoxColumn.DataPropertyName = "ImePU";
            this.imePUDataGridViewTextBoxColumn.HeaderText = "ImePU";
            this.imePUDataGridViewTextBoxColumn.Name = "imePUDataGridViewTextBoxColumn";
            // 
            // imeDUDataGridViewTextBoxColumn
            // 
            this.imeDUDataGridViewTextBoxColumn.DataPropertyName = "ImeDU";
            this.imeDUDataGridViewTextBoxColumn.HeaderText = "ImeDU";
            this.imeDUDataGridViewTextBoxColumn.Name = "imeDUDataGridViewTextBoxColumn";
            // 
            // kvota1DataGridViewTextBoxColumn
            // 
            this.kvota1DataGridViewTextBoxColumn.DataPropertyName = "Kvota1";
            this.kvota1DataGridViewTextBoxColumn.HeaderText = "Kvota1";
            this.kvota1DataGridViewTextBoxColumn.Name = "kvota1DataGridViewTextBoxColumn";
            // 
            // kvotaXDataGridViewTextBoxColumn
            // 
            this.kvotaXDataGridViewTextBoxColumn.DataPropertyName = "KvotaX";
            this.kvotaXDataGridViewTextBoxColumn.HeaderText = "KvotaX";
            this.kvotaXDataGridViewTextBoxColumn.Name = "kvotaXDataGridViewTextBoxColumn";
            // 
            // kvota2DataGridViewTextBoxColumn
            // 
            this.kvota2DataGridViewTextBoxColumn.DataPropertyName = "Kvota2";
            this.kvota2DataGridViewTextBoxColumn.HeaderText = "Kvota2";
            this.kvota2DataGridViewTextBoxColumn.Name = "kvota2DataGridViewTextBoxColumn";
            // 
            // kvota1XDataGridViewTextBoxColumn
            // 
            this.kvota1XDataGridViewTextBoxColumn.DataPropertyName = "Kvota1X";
            this.kvota1XDataGridViewTextBoxColumn.HeaderText = "Kvota1X";
            this.kvota1XDataGridViewTextBoxColumn.Name = "kvota1XDataGridViewTextBoxColumn";
            // 
            // kvotaX2DataGridViewTextBoxColumn
            // 
            this.kvotaX2DataGridViewTextBoxColumn.DataPropertyName = "KvotaX2";
            this.kvotaX2DataGridViewTextBoxColumn.HeaderText = "KvotaX2";
            this.kvotaX2DataGridViewTextBoxColumn.Name = "kvotaX2DataGridViewTextBoxColumn";
            // 
            // kvota12DataGridViewTextBoxColumn
            // 
            this.kvota12DataGridViewTextBoxColumn.DataPropertyName = "Kvota12";
            this.kvota12DataGridViewTextBoxColumn.HeaderText = "Kvota12";
            this.kvota12DataGridViewTextBoxColumn.Name = "kvota12DataGridViewTextBoxColumn";
            // 
            // rezultatDataGridViewTextBoxColumn
            // 
            this.rezultatDataGridViewTextBoxColumn.DataPropertyName = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.HeaderText = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.Name = "rezultatDataGridViewTextBoxColumn";
            // 
            // datumOdrzavanjaDataGridViewTextBoxColumn
            // 
            this.datumOdrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumOdrzavanja";
            this.datumOdrzavanjaDataGridViewTextBoxColumn.HeaderText = "DatumOdrzavanja";
            this.datumOdrzavanjaDataGridViewTextBoxColumn.Name = "datumOdrzavanjaDataGridViewTextBoxColumn";
            // 
            // satnicaOdrzavanjaDataGridViewTextBoxColumn
            // 
            this.satnicaOdrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "SatnicaOdrzavanja";
            this.satnicaOdrzavanjaDataGridViewTextBoxColumn.HeaderText = "SatnicaOdrzavanja";
            this.satnicaOdrzavanjaDataGridViewTextBoxColumn.Name = "satnicaOdrzavanjaDataGridViewTextBoxColumn";
            // 
            // idDogadjajaDataGridViewTextBoxColumn
            // 
            this.idDogadjajaDataGridViewTextBoxColumn.DataPropertyName = "Id Dogadjaja";
            this.idDogadjajaDataGridViewTextBoxColumn.HeaderText = "Id Dogadjaja";
            this.idDogadjajaDataGridViewTextBoxColumn.Name = "idDogadjajaDataGridViewTextBoxColumn";
            // 
            // dogadjajiBindingSource
            // 
            this.dogadjajiBindingSource.DataMember = "dogadjaji";
            this.dogadjajiBindingSource.DataSource = this.kladionicaDataSet;
            this.dogadjajiBindingSource.CurrentChanged += new System.EventHandler(this.dogadjajiBindingSource_CurrentChanged);
            // 
            // kladionicaDataSet
            // 
            this.kladionicaDataSet.DataSetName = "kladionicaDataSet";
            this.kladionicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogadjajiTableAdapter
            // 
            this.dogadjajiTableAdapter.ClearBeforeFill = true;
            // 
            // fillByIdToolStrip
            // 
            this.fillByIdToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel,
            this.idToolStripTextBox,
            this.fillByIdToolStripButton});
            this.fillByIdToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIdToolStrip.Name = "fillByIdToolStrip";
            this.fillByIdToolStrip.Size = new System.Drawing.Size(880, 25);
            this.fillByIdToolStrip.TabIndex = 5;
            this.fillByIdToolStrip.Text = "fillByIdToolStrip";
            // 
            // idToolStripLabel
            // 
            this.idToolStripLabel.Name = "idToolStripLabel";
            this.idToolStripLabel.Size = new System.Drawing.Size(24, 22);
            this.idToolStripLabel.Text = "ID :";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIdToolStripButton
            // 
            this.fillByIdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIdToolStripButton.Name = "fillByIdToolStripButton";
            this.fillByIdToolStripButton.Size = new System.Drawing.Size(86, 22);
            this.fillByIdToolStripButton.Text = "Pretraga po ID";
            this.fillByIdToolStripButton.ToolTipText = "Pretraga po ID-u\r\n";
            this.fillByIdToolStripButton.Click += new System.EventHandler(this.fillByIdToolStripButton_Click);
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
            // UnosTiketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.b_dodaj);
            this.Controls.Add(this.fillByIdToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UnosTiketa";
            this.Text = "Unos Tiketa";
            this.Load += new System.EventHandler(this.UnosTiketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadjajiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kladionicaDataSet)).EndInit();
            this.fillByIdToolStrip.ResumeLayout(false);
            this.fillByIdToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kladionicaDataSet kladionicaDataSet;
        private System.Windows.Forms.BindingSource dogadjajiBindingSource;
        private kladionicaDataSetTableAdapters.dogadjajiTableAdapter dogadjajiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvotaXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota1XDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvotaX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvota12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satnicaOdrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDogadjajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByIdToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIdToolStripButton;
        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}