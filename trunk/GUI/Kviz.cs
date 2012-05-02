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
    public partial class Kviz : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        int bodovi = 0, br_pitanja = 0,granica=0 , tacan_odgovor = 0 ;
        List<Pitanje> lista_pitanja;
        public Kviz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.PitanjeDAO pd = new DAL.DAL.PitanjeDAO();
            lista_pitanja = pd.getAll();
            granica = lista_pitanja.Count;
            richTextBox1.Text = lista_pitanja[br_pitanja].TekstPitanja;
            r_a.Text = lista_pitanja[br_pitanja].OdgovorA;
            r_b.Text = lista_pitanja[br_pitanja].OdgovorB;
            r_c.Text = lista_pitanja[br_pitanja].OdgovorC;
            r_d.Text = lista_pitanja[br_pitanja].OdgovorD;
            tacan_odgovor = lista_pitanja[br_pitanja].TacanOdgovor;
            br_pitanja++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r_a.Checked == true && tacan_odgovor == 1) {
                bodovi++;
                MessageBox.Show("Tačno! Bodovi : "+bodovi); 
                this.Osvjezi_Pitanje();
            }
            else if (r_b.Checked == true && tacan_odgovor == 2)
            {
                bodovi++;
                MessageBox.Show("Tačno! Bodovi : " + bodovi);
                this.Osvjezi_Pitanje();
            }
            else if (r_c.Checked == true && tacan_odgovor == 3)
            {
                bodovi++;
                MessageBox.Show("Tačno! Bodovi : " + bodovi);
                this.Osvjezi_Pitanje();
            }
            else if (r_d.Checked == true && tacan_odgovor == 4)
            {
                bodovi++;
                MessageBox.Show("Tačno! Bodovi : " + bodovi);
                this.Osvjezi_Pitanje();
            }
            else
            {
                MessageBox.Show("Netačno! Skupili ste "+ tacan_odgovor+ " bodova");
                d.terminirajKonekciju();
                this.Close();
            }
        }
        public void Osvjezi_Pitanje()
        {
            try
            {
                richTextBox1.Text = lista_pitanja[br_pitanja].TekstPitanja;
                r_a.Text = lista_pitanja[br_pitanja].OdgovorA;
                r_b.Text = lista_pitanja[br_pitanja].OdgovorB;
                r_c.Text = lista_pitanja[br_pitanja].OdgovorC;
                r_d.Text = lista_pitanja[br_pitanja].OdgovorD;
                tacan_odgovor = lista_pitanja[br_pitanja].TacanOdgovor;
                if (br_pitanja == granica) throw new Exception("Nema više pitanja!");
                br_pitanja++;
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
                d.terminirajKonekciju();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hvala na igranju! Osvojili ste " + bodovi + " bodova!");
            d.terminirajKonekciju();
            this.Close();
        }
    }
}
