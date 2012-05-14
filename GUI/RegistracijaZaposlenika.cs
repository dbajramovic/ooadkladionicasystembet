using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.Entiteti;
using DAL.Interfejsi;

namespace GUI
{
    public partial class RegistracijaZaposlenika : Form
    {

        public RegistracijaZaposlenika()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (mt_z_pass1.Text != mt_z_pass2.Text) throw new Exception("Password nije isti u oba zaštićena polja!");
                Uposlenik u = new Uposlenik(t_z_ime.Text + " " + t_z_prezime.Text, t_z_jmbg.Text, mt_z_pass1.Text);
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");
                DAL.DAL.UposlenikDAO ud = new DAL.DAL.UposlenikDAO();
                u.IDUposlenika = ud.create(u);
                d.terminirajKonekciju();
                MessageBox.Show("Zaposlenik uspješno dodan!");
                this.Close();
            }
            catch (Exception gh)
            {
                MessageBox.Show(gh.Message);
            }
        }

        private void RegistracijaZaposlenika_Load(object sender, EventArgs e)
        {
            
        }
    }
}
