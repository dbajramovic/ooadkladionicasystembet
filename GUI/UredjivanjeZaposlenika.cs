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
    public partial class UredjivanjeZaposlenika : Form
    {
        public UredjivanjeZaposlenika()
        {
            InitializeComponent();
        }

        private void b_trazi_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.UposlenikDAO tt = d.getDAO.getUposlenikDAO();
            Uposlenik u = tt.getById(Convert.ToInt32(textBox1.Text));
            d.terminirajKonekciju();
            t_z_ime.Text = u.ImePrezime;
            t_z_jmbg.Text = u.Jmbg;
            mt_z_pass1.Text = u.Password;
            mt_z_pass2.Text = u.Password;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
