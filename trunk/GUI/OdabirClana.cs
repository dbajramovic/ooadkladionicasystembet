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
    public partial class OdabirClana : Form
    {
        Boolean jeste_clan;
        public OdabirClana(Boolean dodaj)
        {
            jeste_clan = dodaj;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.ClanDAO cd = new DAL.DAL.ClanDAO();
            Clan trazeni_clan = cd.getById(Convert.ToInt32(textBox1.Text));
            d.terminirajKonekciju();
            l_ime.Text = trazeni_clan.ImePrezime;
            l_jmbg.Text = trazeni_clan.Jmbg;
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jeste_clan = true;
            this.Close();
        }
    }
}
