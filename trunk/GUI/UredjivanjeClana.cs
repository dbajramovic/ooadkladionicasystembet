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
    public partial class UredjivanjeClana : Form
    {
        public UredjivanjeClana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.ClanDAO ud = new DAL.DAL.ClanDAO();
            Clan c = ud.getById(Convert.ToInt32(textBox1.Text));
            d.terminirajKonekciju();
            t_ime.Text = c.ImePrezime;
            t_jmbg.Text = c.Jmbg;
            groupBox1.Visible = true;
        }
    }
}
