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
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");

                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                Dogadjaj rezultat = dd.getById(Convert.ToInt32(t_s_id_dogadjaja.Text));
                d.terminirajKonekciju();
                groupBox1.Visible = true;
                dtp_do.Value = rezultat.DatumOdrzavanja;
                n_satnica_m.Value = rezultat.SatnicaOdrzavanja % 100;
                n_satnica_h.Value = rezultat.SatnicaOdrzavanja / 100;
                List<int> kvote = rezultat.DajDijelove();
                n_kvota1_3.Value = kvote[0];
            }
        }
    }
}
