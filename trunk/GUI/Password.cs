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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encrypt enc = new Encrypt();
            MessageBox.Show(enc.DecryptString(maskedTextBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt enc = new Encrypt();
            MessageBox.Show(enc.EncryptString(maskedTextBox1.Text));
            maskedTextBox1.Text = enc.EncryptString(maskedTextBox1.Text);
        }
    }
}
