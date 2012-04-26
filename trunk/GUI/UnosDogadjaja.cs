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
    public partial class UnosDogadjaja : Form
    {
        public UnosDogadjaja()
        {
            InitializeComponent();
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c_kvota1_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvota1.Checked)
            {
                n_kvota1_1.Visible = false;
                n_kvota1_2.Visible = false;
                n_kvota1_3.Visible = false;
            }
            else
            {
                n_kvota1_1.Visible = true;
                n_kvota1_2.Visible = true;
                n_kvota1_3.Visible = true;
            }

        }

        private void c_kvota1x_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvota1x.Checked)
            {
                n_kvota1x_1.Visible = false;
                n_kvota1x_2.Visible = false;
                n_kvota1x_3.Visible = false;
            }
            else
            {
                n_kvota1x_1.Visible = true;
                n_kvota1x_2.Visible = true;
                n_kvota1x_3.Visible = true;
            }
        }

        private void c_kvotax2_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvotax2.Checked)
            {
                n_kvotax2_1.Visible = false;
                n_kvotax2_2.Visible = false;
                n_kvotax2_3.Visible = false;
            }
            else
            {
                n_kvotax2_1.Visible = true;
                n_kvotax2_2.Visible = true;
                n_kvotax2_3.Visible = true;
            }
        }

        private void c_kvota12_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvota12.Checked)
            {
                n_kvota12_1.Visible = false;
                n_kvota12_2.Visible = false;
                n_kvota12_3.Visible = false;
            }
            else
            {
                n_kvota12_1.Visible = true;
                n_kvota12_2.Visible = true;
                n_kvota12_3.Visible = true;
            }
        }

        private void c_kvotax_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvotax.Checked)
            {
                n_kvotax_1.Visible = false;
                n_kvotax_2.Visible = false;
                n_kvotax_3.Visible = false;
            }
            else
            {
                n_kvotax_1.Visible = true;
                n_kvotax_2.Visible = true;
                n_kvotax_3.Visible = true;
            }
        }

        private void c_kvota2_CheckedChanged(object sender, EventArgs e)
        {
            if (!c_kvota2.Checked)
            {
                n_kvota2_1.Visible = false;
                n_kvota2_2.Visible = false;
                n_kvota2_3.Visible = false;
            }
            else
            {
                n_kvota2_1.Visible = true;
                n_kvota2_2.Visible = true;
                n_kvota2_3.Visible = true;
            }
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            double kvota1,kvotax,kvota2,kvota1x,kvotax2,kvota12;
            kvota1=Convert.ToInt32(n_kvota1_1.Value)+(Convert.ToInt32(n_kvota1_2.Value)*0.1)+(Convert.ToInt32(n_kvota1_3.Value)*0.01);
            kvotax=Convert.ToInt32(n_kvotax_1.Value)+(Convert.ToInt32(n_kvotax_2.Value)*0.1)+(Convert.ToInt32(n_kvotax_3.Value)*0.01);
            kvota2=Convert.ToInt32(n_kvota2_1.Value)+(Convert.ToInt32(n_kvota2_2.Value)*0.1)+(Convert.ToInt32(n_kvota2_3.Value)*0.01);
            kvota1x=Convert.ToInt32(n_kvota1x_1.Value)+(Convert.ToInt32(n_kvota1x_2.Value)*0.1)+(Convert.ToInt32(n_kvota1x_3.Value)*0.01);
            kvotax2=Convert.ToInt32(n_kvotax2_1.Value)+(Convert.ToInt32(n_kvotax2_2.Value)*0.1)+(Convert.ToInt32(n_kvotax2_3.Value)*0.01);
            kvota12=Convert.ToInt32(n_kvota12_1.Value)+(Convert.ToInt32(n_kvota12_2.Value)*0.1)+(Convert.ToInt32(n_kvota12_3.Value)*0.01);
            if (!c_kvota1.Checked) kvota1=1.00;
            if (!c_kvotax.Checked) kvotax=1.00;
            if (!c_kvota2.Checked) kvota2=1.00;
            if (!c_kvota1x.Checked) kvota1x=1.00;
            if (!c_kvotax2.Checked) kvotax2=1.00;
            if (!c_kvota12.Checked) kvota12=1.00;
            Dogadjaj dog = new Dogadjaj(t_imeprvogucesnika.Text, t_imedrugogucesnika.Text, kvota1, kvotax, kvota2, kvota1x, kvotax2, kvota12);
            try
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");

                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                dog.Id = dd.create(dog);
                d.terminirajKonekciju();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);

            }
            MessageBox.Show("Događaj uspješno stvoren!");
        }

        private void UnosDogadjaja_Load(object sender, EventArgs e)
        {

        }
    }
}

