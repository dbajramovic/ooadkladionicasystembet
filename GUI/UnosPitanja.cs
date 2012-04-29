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
    public partial class UnosPitanja : Form
    {
        public UnosPitanja()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int to=0;
            if (radioButton1.Checked == true) to = 1;
            if (radioButton2.Checked == true) to = 2;
            if (radioButton3.Checked == true) to = 3;
            if (radioButton4.Checked == true) to = 4;
            DAL.Entiteti.Pitanje pit = new Pitanje(richTextBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, to);
            MessageBox.Show("Pitanje uspješno stvoreno!");
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.PitanjeDAO pd = new DAL.DAL.PitanjeDAO();
            pit.Id = pd.create(pit);
            d.terminirajKonekciju();
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
