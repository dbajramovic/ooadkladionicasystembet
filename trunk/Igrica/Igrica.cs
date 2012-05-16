using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ball_Escape
{
    public partial class Igrica : Form
    {
        public Igrica()
        {
            InitializeComponent();
        }
        int NivoZaUcitati = 1;
        int iSpeed = 7;
        bool PomjeriLoptuLijevo = false;
        bool PomjeriLoptuDesno = false;
        bool PomjeriLoptuGore = false;
        bool PomjeriLoptuDole = false;
        bool IgraSe = false;
        bool LoptaSeMozeKretati = true;
        int TopLvl = 18;
        int iFails = 0;
        bool Obrnuto = false;
        bool btnFunction = false;
        Bitmap TrenutniNivo = Ball_Escape.Properties.Resources.Map1;
        private void Form1_Load(object sender, EventArgs e)
        {
            doLoad();
            this.BackgroundImage = Ball_Escape.Properties.Resources.StartBG;
        }
        
        private void tmr1_Tick(object sender, EventArgs e)
        {
            b_nova_igra.Show();
            b_izaberi_nivo.Show();
            if (b_nova_igra.Left < 330) b_nova_igra.Left += 30; else { tmr1.Enabled = false; tmrBallMovement.Enabled = true; }
            if (b_izaberi_nivo.Left > 330) b_izaberi_nivo.Left -= 30; else { tmr1.Enabled = false; tmrBallMovement.Enabled = true; }
        }
        private void doLoad()
        {
            tmr1.Enabled = true; b_nova_igra.Left = -330; b_izaberi_nivo.Left = 990;
        }
        
        public void unLoadnProceed()
        {
            tmr2.Enabled = true; b_nova_igra.Left = 330; b_izaberi_nivo.Left = 330;
        }
        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (b_nova_igra.Left > -990) b_nova_igra.Left -= 30;
            else
            {
                tmr2.Enabled = false;
                UcitajNivo();
                b_nova_igra.Hide();
                b_izaberi_nivo.Hide();
                this.Focus();
                tmrBallMovement.Enabled = true;
            }
            if (b_izaberi_nivo.Left < 990) b_izaberi_nivo.Left += 30;
            else
            {
                tmr2.Enabled = false;
                UcitajNivo();
                b_nova_igra.Hide();
                b_izaberi_nivo.Hide();
                this.Focus();
                tmrBallMovement.Enabled = true;
            }
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 1;
            unLoadnProceed();
            IgraSe = true;
            timerObrni.Enabled = true;
        }
        private void btnSelectLevels_Click(object sender, EventArgs e)
        {
            unLoadnGoToLvls();
        }
        public void UcitajNivo()
        {
            switch (NivoZaUcitati)
            {
                case 1:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map1;
                        break;
                    }
                case 2:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map2;
                        break;
                    }
                case 3:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map3;
                        break;
                    }
                case 4:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map4;
                        break;
                    }
                case 5:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 6:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map6;
                        break;
                    }
                case 7:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map7;
                        break;
                    }
                case 8:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map8;
                        break;
                    }
                case 9:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map9;
                        break;
                    }
                case 10:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map10;
                        break;
                    }
                case 11:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map11;
                        break;
                    }
                case 12:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map12;
                        break;
                    }
                case 13:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map13;
                        break;
                    }
                case 14:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map14;
                        break;
                    }
                case 15:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map15;
                        break;
                    }
                case 16:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 17:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 18:
                    {
                        TrenutniNivo = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            this.BackgroundImage = TrenutniNivo;
            btnLvl1.Hide();
            btnLvl2.Hide();
            btnLvl3.Hide();
            btnLvl4.Hide();
            btnLvl5.Hide();
            btnLvl6.Hide();
            btnLvl7.Hide();
            btnLvl8.Hide();
            btnLvl9.Hide();
            btnLvl10.Hide();
            btnLvl11.Hide();
            btnLvl12.Hide();
            btnLvl13.Hide();
            btnLvl14.Hide();
            btnLvl15.Hide();
            btnLvl16.Hide();
            btnLvl17.Hide();
            btnLvl18.Hide();
            PostaviLoptuNaPocetak();
            IgraSe = true;
            this.Focus();
        }

        public void PostaviLoptuNaPocetak() { pbBall.Location = new Point(928, 3); pbBall.Show(); } 
        private void tmrLBLRefresher_Tick(object sender, EventArgs e)
        {
            lblBTNDgnstcs.Show();
            lblBTNDgnstcs.Text = Convert.ToString(b_nova_igra.Left);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A && LoptaSeMozeKretati)
            {
                //LoptaSeMozeKretati = false;
                bool bCan = false;
                 if (!Obrnuto){
                     bCan = PomjeriLoptu(2);
                 }
                 if (Obrnuto)
                 {
                     bCan = PomjeriLoptu(4);
                 }
                if (bCan)
                {
                    if(!Obrnuto)
                        PomjeriLoptuLijevo = true;
                    if (Obrnuto)
                        PomjeriLoptuDesno = true;
                    //pbBall.Left -= iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Left -= 1;
                    }*/
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D && LoptaSeMozeKretati)
            {
                //LoptaSeMozeKretati = false;
                bool bCan = false;
                if (!Obrnuto)
                    bCan = PomjeriLoptu(4);
                if (Obrnuto)
                    bCan = PomjeriLoptu(2);
                if (bCan)
                {
                    if(!Obrnuto)
                    PomjeriLoptuDesno = true;
                    if (Obrnuto)
                    PomjeriLoptuLijevo = true;
                    //pbBall.Left += iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Left += 1;
                    }*/
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W && LoptaSeMozeKretati)
            {
                //LoptaSeMozeKretati = false;
                bool bCan = PomjeriLoptu(1);
                if (bCan)
                {
                    PomjeriLoptuGore = true;
                    //pbBall.Top -= iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Top -= 1;
                    }*/
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S && LoptaSeMozeKretati)
            {
                //LoptaSeMozeKretati = false;
                bool bCan = PomjeriLoptu(3);
                if (bCan)
                {
                    PomjeriLoptuDole = true;
                    //pbBall.Top += iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Top += 1;
                    }*/
                }
            }
        }
        public bool PomjeriLoptu(short WhereTo) //WhereTo: 1 - Up, 2- Left, 3 - Down, 4 - Right
        {
            Color cWhite = Color.FromArgb(255, 255, 255, 255);
            bool Retturn = false;
            switch (WhereTo)
            {
                case 1: //Up
                    {
                        if (pbBall.Top > iSpeed)
                        {
                            int WPCounter = 0;
                            for (int i = 1; i <= iSpeed; i++)
                            {
                                for (int i1 = 1; i1 < pbBall.Width; i1++)
                                {
                                    Color Pixell = TrenutniNivo.GetPixel(pbBall.Left + i1 - 1, pbBall.Top - 2);
                                    if (Pixell == cWhite)
                                    {
                                        WPCounter++;
                                    }
                                }
                            }
                            if (WPCounter == 0)
                            {
                                Retturn = true;
                            }
                            else
                            {
                                PostaviLoptuNaPocetak();
                            }
                        }
                        break;
                    }
                case 2: //Left
                    {
                        if (pbBall.Left > iSpeed)
                        {
                            int WPCounter = 0;
                            for (int i = 1; i <= iSpeed; i++)
                            {
                                for (int i1 = 1; i1 < pbBall.Height; i1++)
                                {
                                    Color Pixell = TrenutniNivo.GetPixel(pbBall.Left - 5, pbBall.Top + i1 - 1);
                                    if (Pixell == cWhite)
                                    {
                                        WPCounter++;
                                    }
                                }
                            }
                            if (WPCounter == 0)
                            {
                                Retturn = true;
                            }
                            else
                            {
                                PostaviLoptuNaPocetak();
                            }
                        }
                        break;
                    }
                case 3: //Down
                    {
                        if (pbBall.Top + pbBall.Height + iSpeed < this.Height)
                        {
                            int WPCounter = 0;
                            for (int i = 1; i <= iSpeed; i++)
                            {
                                for (int i1 = 1; i1 < pbBall.Height; i1++)
                                {
                                    Color Pixell = TrenutniNivo.GetPixel(pbBall.Left + i1 - 1, pbBall.Top + i1 - 1);
                                    if (Pixell == cWhite)
                                    {
                                        WPCounter++;
                                    }
                                }
                            }
                            if (WPCounter == 0)
                            {
                                Retturn = true;
                            }
                            else
                            {
                                PostaviLoptuNaPocetak();
                            }
                        }
                        break;
                    }
                case 4: //Right
                    {
                        if (pbBall.Left + pbBall.Width + iSpeed < this.Width)
                        {
                            int WPCounter = 0;
                            for (int i = 1; i <= iSpeed; i++)
                            {
                                for (int i1 = 1; i1 < pbBall.Height; i1++)
                                {
                                    Color Pixell = TrenutniNivo.GetPixel(pbBall.Left + 5 + pbBall.Width, pbBall.Top + i1 - 1);
                                    if (Pixell == cWhite)
                                    {
                                        WPCounter++;
                                    }
                                }
                            }
                            if (WPCounter == 0)
                            {
                                Retturn = true;
                            }
                            else
                            {
                                PostaviLoptuNaPocetak();
                            }
                        }
                        break;
                    }
                default:
                    {
                        Retturn = false;
                        break;
                    }
            }
            return Retturn;
        }
        private void tmrBallMovement_Tick(object sender, EventArgs e)
        {
            if (IgraSe && LoptaSeMozeKretati)
            {
                LoptaSeMozeKretati = false;
                if (PomjeriLoptuLijevo)
                {
                    bool bCan = false;
                    bCan = PomjeriLoptu(2);
                    if (bCan)
                    {
                        pbBall.Left -= iSpeed;
                        CheckLevelClear();
                        LoptaSeMozeKretati = true;
                    }
                }
                if (PomjeriLoptuDesno)
                {
                    bool bCan = false;
                    bCan = PomjeriLoptu(4);
                    if (bCan)
                    {
                        pbBall.Left += iSpeed;
                        CheckLevelClear();
                        LoptaSeMozeKretati = true;
                    }
                }
                if (PomjeriLoptuGore)
                {
                    bool bCan = false;
                    bCan = PomjeriLoptu(1);
                    if (bCan)
                    {
                        pbBall.Top -= iSpeed;
                        CheckLevelClear();
                        LoptaSeMozeKretati = true;
                    }
                }
                if (PomjeriLoptuDole)
                {
                    bool bCan = false;
                    bCan = PomjeriLoptu(3);
                    if (bCan)
                    {
                        pbBall.Top += iSpeed;
                        CheckLevelClear();
                        LoptaSeMozeKretati = true;
                    }
                }
                LoptaSeMozeKretati = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                    PomjeriLoptuLijevo = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                    PomjeriLoptuDesno = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                    PomjeriLoptuGore = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                    PomjeriLoptuDole = false;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*int Counter = 0;
            Color White = Color.FromArgb(255, 255, 255, 255);
            for (int i = 1; i < this.Width; i++)
            {
                for (int k = 1; k < this.Height; k++)
                {
                    if (TrenutniNivo.GetPixel(i, k) == White)
                    {
                        Counter++;
                    }
                }
            }
            MessageBox.Show(Counter.ToString());*/
        }
        public void CheckLevelClear()
        {
            if (pbBall.Left < 70 && pbBall.Top > 600)
            {
                LevelClear();
            }
        }
        public void LevelClear()
        {
            if (NivoZaUcitati < TopLvl)
            {
                lblClear.Font = new Font(lblClear.Font.FontFamily, 72);
                this.BackgroundImage = null;
                IgraSe = false;
                PostaviLoptuNaPocetak();
                pbBall.Hide();
                lblClear.Text = "Level " + NivoZaUcitati + " Clear";
                lblClear.Left = (this.Width - lblClear.Width) / 2;
                lblClear.Show();
                btnNext.Text = "Next Level";
                btnFunction = false;
                btnNext.Show();
            }
            else
            {
                pbBall.Hide();
                this.BackgroundImage = null;
                lblClear.Font = new Font(lblClear.Font.FontFamily, 50);
                lblClear.Text = "Congratulations!";
                lblClear.Left = (this.Width - lblClear.Width) / 2;
                lblComplete.Font = new Font(lblClear.Font.FontFamily, 50);
                lblComplete.Text = "You have completed the game!";
                lblComplete.Left = (this.Width - lblComplete.Width) / 2;
                lblComplete.Show();
                btnNext.Text = "Main Menu";
                lblClear.Show();
                btnFunction = true;
                btnNext.Show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (btnFunction)
            {
                case true:
                    {
                        lblClear.Hide();
                        lblComplete.Hide();
                        btnNext.Hide();
                        this.BackgroundImage = Ball_Escape.Properties.Resources.StartBG;
                        PostaviLoptuNaPocetak();
                        pbBall.Hide();
                        IgraSe = false;
                        doLoad();
                        break;
                    }
                case false:
                    {
                        lblClear.Hide();
                        btnNext.Hide();
                        PostaviLoptuNaPocetak();
                        pbBall.Hide();
                        IgraSe = false;
                        NivoZaUcitati++;
                        UcitajNivo();
                        break;
                    }
                    PomjeriLoptuDole = false;
                    PomjeriLoptuLijevo = false;
                    PomjeriLoptuGore = false;
                    PomjeriLoptuDesno = false;
                    LoptaSeMozeKretati = true;
            }
        }        
        public void unLoadnGoToLvls()
        {
            timer1.Enabled = true; b_nova_igra.Left = 330; b_izaberi_nivo.Left = 330;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b_nova_igra.Left > -990) b_nova_igra.Left -= 30;
            else
            {
                timer1.Enabled = false;
                b_nova_igra.Hide();
                b_izaberi_nivo.Hide();
                this.Focus();
                SelectLevelsv();
            }
            if (b_izaberi_nivo.Left < 990) b_izaberi_nivo.Left += 30;
            else
            {
                timer1.Enabled = false;
                b_nova_igra.Hide();
                b_izaberi_nivo.Hide();
                this.Focus();
                SelectLevelsv();
            }
        }

        private void btnLvl1_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 1;
            UcitajNivo();
        }

        private void btnLvl2_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 2;
            UcitajNivo();
        }

        private void btnLvl3_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 3;
            UcitajNivo();
        }

        private void btnLvl4_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 4;
            UcitajNivo();
        }

        private void btnLvl5_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 5;
            UcitajNivo();
        }

        public void SelectLevelsv()
        {
            this.BackgroundImage = Ball_Escape.Properties.Resources.SLBackground;
            btnLvl1.Show();
            btnLvl2.Show();
            btnLvl3.Show();
            btnLvl4.Show();
            btnLvl5.Show();
            btnLvl6.Show();
            btnLvl7.Show();
            btnLvl8.Show();
            btnLvl9.Show();
            btnLvl10.Show();
            btnLvl11.Show();
            btnLvl12.Show();
            btnLvl13.Show();
            btnLvl14.Show();
            btnLvl15.Show();
            btnLvl16.Show();
            btnLvl17.Show();
            btnLvl18.Show();
        }

        private void btnLvl7_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 7;
            UcitajNivo();
        }

        private void btnLvl6_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 6;
            UcitajNivo();
        }

        private void btnLvl8_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 8;
            UcitajNivo();
        }

        private void btnLvl9_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 9;
            UcitajNivo();
        }

        private void btnLvl10_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 10;
            UcitajNivo();
        }

        private void btnLvl11_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 11;
            UcitajNivo();
        }

        private void btnLvl12_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 12;
            UcitajNivo();
        }

        private void btnLvl13_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 13;
            UcitajNivo();
        }

        private void btnLvl14_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 14;
            UcitajNivo();
        }

        private void btnLvl15_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 15;
            UcitajNivo();
        }

        private void btnLvl16_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 16;
            UcitajNivo();
        }

        private void btnLvl17_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 17;
            UcitajNivo();
        }

        private void btnLvl18_Click(object sender, EventArgs e)
        {
            NivoZaUcitati = 18;
            UcitajNivo();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {

        }
        System.Random r = new System.Random();
        private void timerObrni_Tick(object sender, EventArgs e)
        {
            int broj = 17;
            int rand = r.Next(1,75);
            if (broj == rand)
            {
                if (Obrnuto) Obrnuto = false;
                if(!Obrnuto) Obrnuto = true;
                if (!label1.Visible) label1.Visible = true;
                if (label1.Visible) label1.Visible = false;
                
            }
        }



        }
    }
