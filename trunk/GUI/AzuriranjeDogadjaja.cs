using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAL;
using DAL.Interfejsi;
using DAL.Entiteti;

namespace GUI
{
    public partial class AzuriranjeDogadjaja : Form
    {
        Boolean selektirano = false;
        MySqlConnection p;
        Dogadjaj rezultat;
        List<Dogadjaj> lista_dogadjaja = new List<Dogadjaj>();
        List<Ucesnik> lista_ucesnika1, lista_ucesnika2;
        public AzuriranjeDogadjaja()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if (t_s_id_dogadjaja.Text == " ")
            {
                MessageBox.Show("Nije unesen ID!");
            }
            else
            {
                
            }
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
           /* double kvota1, kvotax, kvota2, kvota1x, kvotax2, kvota12;
            kvota1 = Convert.ToInt32(n_kvota1_1.Value) + (Convert.ToInt32(n_kvota1_2.Value) * 0.1) + (Convert.ToInt32(n_kvota1_3.Value) * 0.01);
            kvotax = Convert.ToInt32(n_kvotax_1.Value) + (Convert.ToInt32(n_kvotax_2.Value) * 0.1) + (Convert.ToInt32(n_kvotax_3.Value) * 0.01);
            kvota2 = Convert.ToInt32(n_kvota2_1.Value) + (Convert.ToInt32(n_kvota2_2.Value) * 0.1) + (Convert.ToInt32(n_kvota2_3.Value) * 0.01);
            kvota1x = Convert.ToInt32(n_kvota1x_1.Value) + (Convert.ToInt32(n_kvota1x_2.Value) * 0.1) + (Convert.ToInt32(n_kvota1x_3.Value) * 0.01);
            kvotax2 = Convert.ToInt32(n_kvotax2_1.Value) + (Convert.ToInt32(n_kvotax2_2.Value) * 0.1) + (Convert.ToInt32(n_kvotax2_3.Value) * 0.01);
            kvota12 = Convert.ToInt32(n_kvota12_1.Value) + (Convert.ToInt32(n_kvota12_2.Value) * 0.1) + (Convert.ToInt32(n_kvota12_3.Value) * 0.01);
            if (!c_kvota1.Checked) kvota1 = 1.00;
            if (!c_kvotax.Checked) kvotax = 1.00;
            if (!c_kvota2.Checked) kvota2 = 1.00;
            if (!c_kvota1x.Checked) kvota1x = 1.00;
            if (!c_kvotax2.Checked) kvotax2 = 1.00;
            if (!c_kvota12.Checked) kvota12 = 1.00;
            rezultat.ImePrvogUcesnika = t_ime_prvog_ucesnika.Text;
            rezultat.ImeDrugogUcesnika = t_imedrugogucesnika.Text;
            rezultat.Kvota_1 = kvota1;
            rezultat.Kvota_X = kvotax;
            rezultat.Kvota_2 = kvota2;
            rezultat.Kvota_1X = kvota1x;
            rezultat.Kvota_X2 = kvotax2;
            rezultat.Kvota_12 = kvota12;
            rezultat.Rezultat = Convert.ToInt32(n_rezultat.Value);
            rezultat.DatumOdrzavanja = Convert.ToString(dtp_do.Value);
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
            Dogadjaj temp = dd.update(rezultat);
            MessageBox.Show("Događaj promijenjen!");
            d.terminirajKonekciju();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
            dd.delete(rezultat);
            MessageBox.Show("Događaj izbrisan!");
      
        }

        private void t_s_id_dogadjaja_TextChanged(object sender, EventArgs e)
        {
            
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
            lista_dogadjaja = dd.getByExample(t_s_id_dogadjaja.Text,"");
            d.terminirajKonekciju();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista_dogadjaja;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
          
            
        }

        private void c_imeprvogucenika_TextUpdate(object sender, EventArgs e)
        {
            lista_ucesnika2 = null;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");

            DAL.DAL.UcesnikDAO dd = d.getDAO.getUcesnikDAO();
            lista_ucesnika2 = dd.getByExample(c_imedrugogucesnika.Text, "");
            d.terminirajKonekciju();
            c_imedrugogucesnika.DataSource = null;
            c_imedrugogucesnika.DataSource = lista_ucesnika2;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
              
                double kvota1, kvotax, kvota2, kvota1x, kvotax2, kvota12;
                int temp;
                Dogadjaj rezultat = new Dogadjaj(Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[7].Value), Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[8].Value), Convert.ToString(dataGridView1.SelectedRows[0].Cells[9].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[10].Value));
                groupBox1.Visible = true;
                dtp_do.Value = Convert.ToDateTime(rezultat.DatumOdrzavanja);
                n_satnica_m.Value = rezultat.SatnicaOdrzavanja % 100;
                n_satnica_h.Value = rezultat.SatnicaOdrzavanja / 100;
                c_imedrugogucesnika.Text = rezultat.ImeDrugogUcesnika;
                c_imeprvogucenika.Text = rezultat.ImePrvogUcesnika;
                //n_rezultat.Value = rezultat.Rezultat;
                kvota1 = rezultat.Kvota_1;
                kvotax = rezultat.Kvota_X;
                kvota2 = rezultat.Kvota_2;
                kvota1x = rezultat.Kvota_1X;
                kvotax2 = rezultat.Kvota_X2;
                kvota12 = rezultat.Kvota_12;
                n_kvota1_1.Value = Convert.ToInt32(kvota1);
                kvota1 *= 10;
                temp = Convert.ToInt32(kvota1);
                while (temp >= 10)
                    temp -= 10;
                n_kvota1_2.Value = temp;
                while (kvota1 >= 10)
                    kvota1 -= 10;
                kvota1 *= 10;
                temp = Convert.ToInt32(kvota1);
                while (temp >= 10)
                    temp -= 10;
                n_kvota1_3.Value = temp;
                n_kvotax_1.Value = Convert.ToInt32(kvotax);
                kvota1 *= 10;
                temp = Convert.ToInt32(kvotax);
                while (temp >= 10)
                    temp -= 10;
                n_kvotax_2.Value = temp;
                while (kvotax >= 10)
                    kvotax -= 10;
                kvotax *= 10;
                temp = Convert.ToInt32(kvotax);
                while (temp >= 10)
                    temp -= 10;
                n_kvotax_3.Value = temp;
                n_kvota2_1.Value = Convert.ToInt32(kvota2);
                kvota2 *= 10;
                temp = Convert.ToInt32(kvota2);
                while (temp >= 10)
                    temp -= 10;
                n_kvota2_2.Value = temp;
                while (kvota2 > 10)
                    kvota2 -= 10;
                kvota2 *= 10;
                temp = Convert.ToInt32(kvota2);
                while (temp >= 10)
                    temp -= 10;
                n_kvota2_3.Value = temp;
                n_kvota1x_1.Value = Convert.ToInt32(kvota1x);
                kvota1x *= 10;
                temp = Convert.ToInt32(kvota1x);
                while (temp >= 10)
                    temp -= 10;
                n_kvota1x_2.Value = temp;
                while (kvota1x > 10)
                    kvota1x -= 10;
                kvota1x *= 10;
                temp = Convert.ToInt32(kvota1x);
                while (temp >= 10)
                    temp -= 10;
                n_kvota1x_3.Value = temp;
                n_kvota12_1.Value = Convert.ToInt32(kvota12);
                kvota12 *= 10;
                temp = Convert.ToInt32(kvota12);
                while (temp >= 10)
                    temp -= 10;
                n_kvota12_2.Value = temp;
                while (kvota12 > 10)
                    kvota12 -= 10;
                kvota12 *= 10;
                temp = Convert.ToInt32(kvota12);
                while (temp >= 10)
                    temp -= 10;
                n_kvota12_3.Value = temp;
        }
    }
}
