using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DAL.Entiteti;
using DAL.Interfejsi;
using System.Threading;
namespace GUI
{
    public partial class SystemBet : Form
    {
        Thread isteknuce;
        List<Tiket> lista_za_provjeru = new List<Tiket>();
        public SystemBet()
        {
            InitializeComponent();
        }

        private void SystemBet_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Logo.png";
            foreach (Tiket t in lista_za_provjeru)
            {
                MessageBox.Show(Convert.ToString(t.Uplata));
            }
            isteknuce = new Thread(PrvojeraIsteknuca);
            isteknuce.Start();           
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

        private void b_stvaranje_t_Click(object sender, EventArgs e)
        {
            UnosTiketa ut = new UnosTiketa();
            ut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kviz k = new Kviz();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnosPitanja up = new UnosPitanja();
            up.Show();
        }

        private void b_registracija_c_Click(object sender, EventArgs e)
        {
            UnosClana uc = new UnosClana();
            uc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProvjeraDobitka pd = new ProvjeraDobitka();
            pd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UredjivanjeZaposlenika uz = new UredjivanjeZaposlenika();
            uz.Show();
        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void događajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosDogadjaja ud = new UnosDogadjaja();
            ud.Show();
        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosTiketa ut = new UnosTiketa();
            ut.Show();
        }

        private void članaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosClana uc = new UnosClana();
            uc.Show();
        }

        private void uposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistracijaZaposlenika rz = new RegistracijaZaposlenika();
            rz.Show();
        }

        private void događajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AzuriranjeDogadjaja ad = new AzuriranjeDogadjaja();
            ad.Show();
        }

        private void članaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UredjivanjeClana uc = new UredjivanjeClana();
            uc.Show();
        }

        private void uposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UredjivanjeZaposlenika uz = new UredjivanjeZaposlenika();
            uz.Show();
        }

        private void provjeraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dobitkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void printajPonuduToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void printajPonuduToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintanjePonude pp = new PrintanjePonude();
            pp.Show();
        }

        private void snimiProdajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");
                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                List<Dogadjaj> lista_za_ponudu = dd.getAll();
                d.terminirajKonekciju();
            XmlTextWriter xt = new XmlTextWriter("Ponuda.xml",null);
            xt.WriteStartDocument();
            xt.WriteStartElement("Dogadjaji");
            foreach(Dogadjaj f in lista_za_ponudu)
            {
                xt.WriteStartElement("Dogadjaj");
                    xt.WriteStartElement("Id");
                    xt.WriteString(Convert.ToString(f.Id));
                    xt.WriteEndElement();
                    xt.WriteStartElement("ImePrvogUcesnika");
                    xt.WriteString(f.ImePrvogUcesnika);
                    xt.WriteEndElement();
                    xt.WriteStartElement("ImeDrugogUcesnika");
                    xt.WriteString(f.ImeDrugogUcesnika);
                    xt.WriteEndElement();
                    xt.WriteStartElement("Kvota1");
                    xt.WriteString(Convert.ToString(f.Kvota_1));
                    xt.WriteEndElement();
                    xt.WriteStartElement("KvotaX");
                    xt.WriteString(Convert.ToString(f.Kvota_X));
                    xt.WriteEndElement();
                    xt.WriteStartElement("Kvota2");
                    xt.WriteString(Convert.ToString(f.Kvota_2));
                    xt.WriteEndElement();
                    xt.WriteStartElement("Kvota1X");
                    xt.WriteString(Convert.ToString(f.Kvota_1X));
                    xt.WriteEndElement();
                    xt.WriteStartElement("KvotaX2");
                    xt.WriteString(Convert.ToString(f.Kvota_X2));
                    xt.WriteStartElement("Kvota12");
                    xt.WriteEndElement();
                    xt.WriteString(Convert.ToString(f.Kvota_12));
                    xt.WriteEndElement();
                    xt.WriteStartElement("DatumOdrzavanja");
                    xt.WriteString(f.DatumOdrzavanja);
                    xt.WriteEndElement();
                    xt.WriteStartElement("SatnicaOdrzavanja");
                    xt.WriteString(Convert.ToString(f.SatnicaOdrzavanja));
                    xt.WriteEndElement();
                xt.WriteEndElement();
            }
            xt.WriteEndElement();
            xt.WriteEndDocument();
            xt.Flush();
            xt.Close();
            MessageBox.Show("Ponuda uspješno snimljena u Ponuda.xml!");
        }


        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kladionica SystemBet by Dado Bajramović,Dino Ahmić,Amna Šukrija 2012");
        }

        private void tiketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProvjeraDobitka pd = new ProvjeraDobitka();
            pd.Show();
        }
        public void PrvojeraIsteknuca()
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.TiketDAO tt = d.getDAO.getTiketDAO();
            lista_za_provjeru = tt.getAll();
            d.terminirajKonekciju();
            int broj_isteknutih = 0;
            foreach (Tiket t in lista_za_provjeru)
                {
                    if (t.JeliKasno(DateTime.Now))
                    {
                        broj_isteknutih++;
                    }

                }
            toolStripStatusLabel1.Text = "Trenutačno je nemoguće stronirati " + broj_isteknutih + " tiketa!";
        }

        private void SystemBet_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SystemBet_Leave(object sender, EventArgs e)
        {
            isteknuce.Suspend();
        }

        private void SystemBet_Enter(object sender, EventArgs e)
        {
            isteknuce.Resume();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password p = new Password();
            p.Show();
        }
    }
}
