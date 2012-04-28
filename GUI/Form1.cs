using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_unos_d_Click(object sender, EventArgs e)
        {
            UnosDogadjaja u = new UnosDogadjaja();
            u.Show();
        }

        private void b_izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AzuriranjeDogadjaja ad = new AzuriranjeDogadjaja();
            ad.Show();
        }

        private void b_registracija_z_Click(object sender, EventArgs e)
        {
            Password f2 = new Password();
            f2.Show();
        }
    }
}
