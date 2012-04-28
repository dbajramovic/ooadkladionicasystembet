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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "w00t")
            {
                RegistracijaZaposlenika rz = new RegistracijaZaposlenika();
                rz.Show();
                this.Close();
            }
            else
                MessageBox.Show("Pogrešan password!");
        }
    }
}
