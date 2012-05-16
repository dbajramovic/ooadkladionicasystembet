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
        #region Variables
        int iLvlToLoad = 1;
        int iSpeed = 7;
        bool bMoveLeft = false;
        bool bMoveRight = false;
        bool bMoveUp = false;
        bool bMoveDown = false;
        bool bPlaying = false;
        bool bCanMove = true;
        int TopLvl = 18;
        int iFails = 0;
        bool btnFunction = false;
        Bitmap LevelCurrent = Ball_Escape.Properties.Resources.Map1;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            doLoad();
            this.BackgroundImage = Ball_Escape.Properties.Resources.StartBG;
        }
        #region Animations
        #region doLoad&tmr1
        private void tmr1_Tick(object sender, EventArgs e)
        {
            btnNewGame.Show();
            btnSelectLevels.Show();
            if (btnNewGame.Left < 330) btnNewGame.Left += 30; else { tmr1.Enabled = false; tmrBallMovement.Enabled = true; }
            if (btnSelectLevels.Left > 330) btnSelectLevels.Left -= 30; else { tmr1.Enabled = false; tmrBallMovement.Enabled = true; }
        }
        private void doLoad()
        {
            tmr1.Enabled = true; btnNewGame.Left = -330; btnSelectLevels.Left = 990;
        }
        #endregion
        #region unLoad&Tmr2
        public void unLoadnProceed()
        {
            tmr2.Enabled = true; btnNewGame.Left = 330; btnSelectLevels.Left = 330;
        }
        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (btnNewGame.Left > -990) btnNewGame.Left -= 30;
            else
            {
                tmr2.Enabled = false;
                LoadLevel();
                btnNewGame.Hide();
                btnSelectLevels.Hide();
                this.Focus();
                tmrBallMovement.Enabled = true;
            }
            if (btnSelectLevels.Left < 990) btnSelectLevels.Left += 30;
            else
            {
                tmr2.Enabled = false;
                LoadLevel();
                btnNewGame.Hide();
                btnSelectLevels.Hide();
                this.Focus();
                tmrBallMovement.Enabled = true;
            }
        }
        #endregion
        #endregion
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 1;
            unLoadnProceed();
            bPlaying = true;
        }
        private void btnSelectLevels_Click(object sender, EventArgs e)
        {
            unLoadnGoToLvls();
        }
        #region Load Level
        public void LoadLevel()
        {
            switch (iLvlToLoad)
            {
                case 1:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map1;
                        break;
                    }
                case 2:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map2;
                        break;
                    }
                case 3:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map3;
                        break;
                    }
                case 4:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map4;
                        break;
                    }
                case 5:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 6:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map6;
                        break;
                    }
                case 7:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map7;
                        break;
                    }
                case 8:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map8;
                        break;
                    }
                case 9:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map9;
                        break;
                    }
                case 10:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map10;
                        break;
                    }
                case 11:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map11;
                        break;
                    }
                case 12:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map12;
                        break;
                    }
                case 13:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map13;
                        break;
                    }
                case 14:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map14;
                        break;
                    }
                case 15:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map15;
                        break;
                    }
                case 16:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 17:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                case 18:
                    {
                        LevelCurrent = Ball_Escape.Properties.Resources.Map5;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            this.BackgroundImage = LevelCurrent;
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
            SetBallToStart();
            bPlaying = true;
            this.Focus();
        }
        #endregion

        #region Sets the ball to the starting position.
        public void SetBallToStart() { pbBall.Location = new Point(928, 3); pbBall.Show(); } 
        #endregion
        private void tmrLBLRefresher_Tick(object sender, EventArgs e)
        {
            lblBTNDgnstcs.Show();
            lblBTNDgnstcs.Text = Convert.ToString(btnNewGame.Left);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region Ball Moves Left
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A && bCanMove)
            {
                //bCanMove = false;
                bool bCan = BallMove(2);
                if (bCan)
                {
                    bMoveLeft = true;
                    //pbBall.Left -= iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Left -= 1;
                    }*/
                }
            }
            #endregion
            #region Ball Moves Right
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D && bCanMove)
            {
                //bCanMove = false;
                bool bCan = BallMove(4);
                if (bCan)
                {
                    bMoveRight = true;
                    //pbBall.Left += iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Left += 1;
                    }*/
                }
            }
            #endregion
            #region Ball Moves Up
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W && bCanMove)
            {
                //bCanMove = false;
                bool bCan = BallMove(1);
                if (bCan)
                {
                    bMoveUp = true;
                    //pbBall.Top -= iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Top -= 1;
                    }*/
                }
            }
            #endregion
            #region Ball Moves Down
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S && bCanMove)
            {
                //bCanMove = false;
                bool bCan = BallMove(3);
                if (bCan)
                {
                    bMoveDown = true;
                    //pbBall.Top += iSpeed;
                    /*for (int i = 1; i <= iSpeed; i++)
                    {
                        pbBall.Top += 1;
                    }*/
                }
            }
            #endregion
        }
        #region Ball Move event
        public bool BallMove(short WhereTo) //WhereTo: 1 - Up, 2- Left, 3 - Down, 4 - Right
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
                                    Color Pixell = LevelCurrent.GetPixel(pbBall.Left + i1 - 1, pbBall.Top - 2);
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
                                SetBallToStart();
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
                                    Color Pixell = LevelCurrent.GetPixel(pbBall.Left - 5, pbBall.Top + i1 - 1);
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
                                SetBallToStart();
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
                                    Color Pixell = LevelCurrent.GetPixel(pbBall.Left + i1 - 1, pbBall.Top + i1 - 1);
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
                                SetBallToStart();
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
                                    Color Pixell = LevelCurrent.GetPixel(pbBall.Left + 5 + pbBall.Width, pbBall.Top + i1 - 1);
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
                                SetBallToStart();
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
        #endregion
        #region pbBall Movement Timer
        private void tmrBallMovement_Tick(object sender, EventArgs e)
        {
            if (bPlaying && bCanMove)
            {
                bCanMove = false;
                if (bMoveLeft)
                {
                    bool bCan = false;
                    bCan = BallMove(2);
                    if (bCan)
                    {
                        pbBall.Left -= iSpeed;
                        CheckLevelClear();
                        bCanMove = true;
                    }
                }
                if (bMoveRight)
                {
                    bool bCan = false;
                    bCan = BallMove(4);
                    if (bCan)
                    {
                        pbBall.Left += iSpeed;
                        CheckLevelClear();
                        bCanMove = true;
                    }
                }
                if (bMoveUp)
                {
                    bool bCan = false;
                    bCan = BallMove(1);
                    if (bCan)
                    {
                        pbBall.Top -= iSpeed;
                        CheckLevelClear();
                        bCanMove = true;
                    }
                }
                if (bMoveDown)
                {
                    bool bCan = false;
                    bCan = BallMove(3);
                    if (bCan)
                    {
                        pbBall.Top += iSpeed;
                        CheckLevelClear();
                        bCanMove = true;
                    }
                }
                bCanMove = true;
            }
        }
        #endregion

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            #region Ball Moves Left
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                    bMoveLeft = false;
            }
            #endregion
            #region Ball Moves Right
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                    bMoveRight = false;
            }
            #endregion
            #region Ball Moves Up
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                    bMoveUp = false;
            }
            #endregion
            #region Ball Moves Down
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                    bMoveDown = false;
            }
            #endregion
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*int Counter = 0;
            Color White = Color.FromArgb(255, 255, 255, 255);
            for (int i = 1; i < this.Width; i++)
            {
                for (int k = 1; k < this.Height; k++)
                {
                    if (LevelCurrent.GetPixel(i, k) == White)
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
            if (iLvlToLoad < TopLvl)
            {
                lblClear.Font = new Font(lblClear.Font.FontFamily, 72);
                this.BackgroundImage = null;
                bPlaying = false;
                SetBallToStart();
                pbBall.Hide();
                lblClear.Text = "Level " + iLvlToLoad + " Clear";
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
                        SetBallToStart();
                        pbBall.Hide();
                        bPlaying = false;
                        doLoad();
                        break;
                    }
                case false:
                    {
                        lblClear.Hide();
                        btnNext.Hide();
                        SetBallToStart();
                        pbBall.Hide();
                        bPlaying = false;
                        iLvlToLoad++;
                        LoadLevel();
                        break;
                    }
                    bMoveDown = false;
                    bMoveLeft = false;
                    bMoveUp = false;
                    bMoveRight = false;
                    bCanMove = true;
            }
        }        
        #region unLoad&Timer1
        public void unLoadnGoToLvls()
        {
            timer1.Enabled = true; btnNewGame.Left = 330; btnSelectLevels.Left = 330;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnNewGame.Left > -990) btnNewGame.Left -= 30;
            else
            {
                timer1.Enabled = false;
                btnNewGame.Hide();
                btnSelectLevels.Hide();
                this.Focus();
                SelectLevelsv();
            }
            if (btnSelectLevels.Left < 990) btnSelectLevels.Left += 30;
            else
            {
                timer1.Enabled = false;
                btnNewGame.Hide();
                btnSelectLevels.Hide();
                this.Focus();
                SelectLevelsv();
            }
        }
        #endregion

        private void btnLvl1_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 1;
            LoadLevel();
        }

        private void btnLvl2_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 2;
            LoadLevel();
        }

        private void btnLvl3_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 3;
            LoadLevel();
        }

        private void btnLvl4_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 4;
            LoadLevel();
        }

        private void btnLvl5_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 5;
            LoadLevel();
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
            iLvlToLoad = 7;
            LoadLevel();
        }

        private void btnLvl6_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 6;
            LoadLevel();
        }

        private void btnLvl8_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 8;
            LoadLevel();
        }

        private void btnLvl9_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 9;
            LoadLevel();
        }

        private void btnLvl10_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 10;
            LoadLevel();
        }

        private void btnLvl11_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 11;
            LoadLevel();
        }

        private void btnLvl12_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 12;
            LoadLevel();
        }

        private void btnLvl13_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 13;
            LoadLevel();
        }

        private void btnLvl14_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 14;
            LoadLevel();
        }

        private void btnLvl15_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 15;
            LoadLevel();
        }

        private void btnLvl16_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 16;
            LoadLevel();
        }

        private void btnLvl17_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 17;
            LoadLevel();
        }

        private void btnLvl18_Click(object sender, EventArgs e)
        {
            iLvlToLoad = 18;
            LoadLevel();
        }



        }
    }
