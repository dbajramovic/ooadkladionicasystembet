using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Entiteti;

namespace GUI
{
    public partial class UnosTiketa : Form
    {
        List<Dogadjaj> ld = new List<Dogadjaj>();
        public UnosTiketa()
        {
            InitializeComponent();
            
        }

        private void UnosTiketa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kladionicaDataSet.dogadjaji' table. You can move, or remove it, as needed.
            this.dogadjajiTableAdapter.Fill(this.kladionicaDataSet.dogadjaji);           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = idToolStripTextBox.Text;
                this.dogadjajiTableAdapter.FillById(this.kladionicaDataSet.dogadjaji, id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dogadjajiTableAdapter.FillById(this.kladionicaDataSet.dogadjaji, idToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dogadjajiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByIdToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dogadjajiTableAdapter.FillById(this.kladionicaDataSet.dogadjaji, idToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            Dogadjaj d = new Dogadjaj(Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[2].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[7].Value), Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[9].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[10].Value));
            d.Rezultat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value);
            try { 
            if (d.DatumOdrzavanja < DateTime.Now) throw new Exception("Taj događaj je već prošao!");
            ld.Add(d);
            dataGridView2.DataSource = ld;
            }
            catch (Exception aad)
            {
                MessageBox.Show(aad.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
