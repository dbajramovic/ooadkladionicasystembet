﻿using System;
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
        List<Dogadjaj> ld1 = new List<Dogadjaj>();
        List<Dogadjaj> ld2;
        public UnosTiketa()
        {
            InitializeComponent();
            
        }

        private void UnosTiketa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kladionicaDataSet.dogadjaji' table. You can move, or remove it, as needed.
            DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");
                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                ld2 = dd.getAll();
                d.terminirajKonekciju();
                dataGridView1.DataSource = ld2;
                dataGridView2.DataSource = ld1;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id;
                id = t_pretraga.Text;
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");
                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                ld1.Add(dd.getById(Convert.ToInt32(id)));
                d.terminirajKonekciju();
                dataGridView2.Update();
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByIdToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void dogadjajiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByIdToolStripButton1_Click(object sender, EventArgs e)
        {
 

        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            Dogadjaj d = new Dogadjaj(Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[7].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[8].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[9].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[10].Value));
            d.Rezultat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value);
            d.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            try { 
            if (Convert.ToDateTime(d.DatumOdrzavanja) < DateTime.Now) throw new Exception("Taj događaj je već prošao!");
            ld1.Add(d);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ld1;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_pretraga_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            try
            {
               
                d.kreirajKonekciju("localhost", "kladionica", "root", "");
                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                ld2.Clear();
                ld2.Add(dd.getById(Convert.ToInt32(t_pretraga.Text)));
                d.terminirajKonekciju();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ld2;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                d.terminirajKonekciju();
            }
        }

        private void c_clan_CheckedChanged(object sender, EventArgs e)
        {
            if (c_clan.Checked == true)
            {
                OdabirClana oc = new OdabirClana();
                oc.Show();
            }
        }
    }
}