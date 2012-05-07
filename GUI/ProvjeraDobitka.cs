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
    public partial class ProvjeraDobitka : Form
    {
        List<Tiket> lista_tiketa = new List<Tiket>();
        public ProvjeraDobitka()
        {
            InitializeComponent();
        }

        private void b_trazi_Click(object sender, EventArgs e)
        {
            lista_tiketa.Clear();
            string id = textBox1.Text;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.TiketDAO tt = d.getDAO.getTiketDAO();
            lista_tiketa.Add(tt.getById(Convert.ToInt32(id)));
            d.terminirajKonekciju();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista_tiketa;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g_izvjestaj.Visible = true;
            Tiket tiket_za_preradu = lista_tiketa[0];
            int brojac=0;
            Boolean valja = true;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.TiketDAO tt = d.getDAO.getTiketDAO();
            tiket_za_preradu.Dogadjaji = tt.DajPovezaneDogadjaje(tiket_za_preradu);
            d.terminirajKonekciju();
            try
            {
                foreach (Dogadjaj drogba in tiket_za_preradu.Dogadjaji)
                {
                    if (drogba.Rezultat == -1) throw new Exception("Događaj nije još završen!");
                    if (drogba.Rezultat != tiket_za_preradu.ListaTipova[brojac])
                    {
                        l_je_li_dobitni.Text = "Tiket nije dobitni, jer rezultat" + brojac + ". događaja nije isti kao i tip!";
                        valja = false;
                        break;
                    }
                }
                if (valja)
                {
                    l_je_li_dobitni.Text = "Tiket je dobitni i dobitak iznosi :" + tiket_za_preradu.Dobitak + " KM!";
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            lista_tiketa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
