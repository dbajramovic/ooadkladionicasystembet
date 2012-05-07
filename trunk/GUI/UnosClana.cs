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
    public partial class UnosClana : Form
    {
        public UnosClana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clan c = new Clan(t_ime.Text + " "+ t_prezime.Text, t_jmbg.Text);
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.ClanDAO cd = new DAL.DAL.ClanDAO();
            c.DajIDClana = cd.create(c);
            d.terminirajKonekciju();
            MessageBox.Show("Ćlan uspješno dodan!");
            this.Close();
        }
    }
}
