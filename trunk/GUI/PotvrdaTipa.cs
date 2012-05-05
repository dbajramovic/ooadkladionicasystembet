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
    public partial class PotvrdaTipa : Form
    {
        Tiket tik;
        Dogadjaj dog;
        public PotvrdaTipa(Tiket t,Dogadjaj d)
        {
            tik = t;
            dog = d;
            InitializeComponent();
        }

        private void r_tip_12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (r_tip_1.Checked == true) tik.DodajDogadjaj(dog, 1);
                if (r_tip_x.Checked == true) tik.DodajDogadjaj(dog, 0);
                if (r_tip_2.Checked == true) tik.DodajDogadjaj(dog, 2);
                if (r_tip_1x.Checked == true) tik.DodajDogadjaj(dog, 10);
                if (r_tip_x2.Checked == true) tik.DodajDogadjaj(dog, 20);
                if (r_tip_12.Checked == true) tik.DodajDogadjaj(dog, 12);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            this.Close();

        }
    }
}
