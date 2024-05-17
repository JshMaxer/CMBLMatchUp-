using MatchUp.Properties;
using System;
using System.Windows.Forms;

namespace MatchUp
{
    public partial class Form1 : Form
    {
        bool king1 = false;
        bool king2 = false;

        bool queen1 = false;
        bool queen2 = false;

        bool peasant1 = false;
        bool peasant2 = false;

        bool warrior1 = false;
        bool warrior2 = false;

        bool beast1 = false;
        bool beast2 = false;

        bool wizard1 = false;
        bool wizard2 = false;

        int clickChecker = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void restartGame()
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();

            this.Close();
        }


        private void BtnImage1_Click(object sender, EventArgs e)
        {
            BtnImage1.Image = Resources.King;
            king1 = true;
            clickChecker++;

            if (king1 == true && king2 == true)
            {
                BtnImage1.Enabled = false;
                BtnImage10.Enabled = false;
            }
        }

        private void BtnImage2_Click(object sender, EventArgs e)
        {
            BtnImage2.Image = Resources.queen;
            queen1 = true;
            clickChecker++;

            if (queen1 == true && queen2 == true)
            {
                BtnImage2.Enabled = false;
                BtnImage8.Enabled = false;
            }
        }

        private void BtnImage3_Click(object sender, EventArgs e)
        {
            BtnImage3.Image = Resources.warrior;
            warrior1 = true;
            clickChecker++;

            if (warrior1 == true && warrior2 == true)
            {
                BtnImage3.Enabled = false;
                BtnImage12.Enabled = false;
            }
        }

        private void BtnImage4_Click(object sender, EventArgs e)
        {
            BtnImage4.Image = Resources.peasant;
            peasant1 = true;
            clickChecker++;

            if (peasant1 == true && peasant2 == true)
            {
                BtnImage4.Enabled = false;
                BtnImage6.Enabled = false;
            }
        }

        private void BtnImage5_Click(object sender, EventArgs e)
        {
            BtnImage5.Image = Resources.wizard;
            wizard1 = true;
            clickChecker++;

            if (wizard1 == true && wizard2 == true)
            {
                BtnImage5.Enabled = false;
                BtnImage11.Enabled = false;
            }

        }

        private void BtnImage6_Click(object sender, EventArgs e)
        {
            BtnImage6.Image = Resources.peasant;
            peasant2 = true;
            clickChecker++;

            if (peasant1 == true && peasant2 == true)
            {
                BtnImage6.Enabled = false;
                BtnImage4.Enabled = false;
            }
        }

        private void BtnImage7_Click(object sender, EventArgs e)
        {
            BtnImage7.Image = Resources.Beast;
            beast1 = true;
            clickChecker++;

            if (beast1 == true && beast2 == true)
            {
                BtnImage7.Enabled = false;
                BtnImage9.Enabled = false;
            }
        }

        private void BtnImage8_Click(object sender, EventArgs e)
        {
            BtnImage8.Image = Resources.queen;
            queen2 = true;
            clickChecker++;

            if (queen1 == true && queen2 == true)
            {
                BtnImage8.Enabled = false;
                BtnImage2.Enabled = false;
            }
        }

        private void BtnImage9_Click(object sender, EventArgs e)
        {
            BtnImage9.Image = Resources.Beast;
            beast2 = true;
            clickChecker++;

            if (beast1 == true && beast2 == true)
            {
                BtnImage9.Enabled = false;
                BtnImage7.Enabled = false;
            }
        }

        private void BtnImage10_Click(object sender, EventArgs e)
        {
            BtnImage10.Image = Resources.King;
            king2 = true;
            clickChecker++;

            if (king1 == true && king2 == true)
            {
                BtnImage10.Enabled = false;
                BtnImage1.Enabled = false;
            }
        }

        private void BtnImage11_Click(object sender, EventArgs e)
        {
            BtnImage11.Image = Resources.wizard;
            wizard2 = true;
            clickChecker++;

            if (wizard1 == true && wizard2 == true)
            {
                BtnImage11.Enabled = false;
                BtnImage5.Enabled = false;
            }
        }

        private void BtnImage12_Click(object sender, EventArgs e)
        {
            BtnImage12.Image = Resources.warrior;
            warrior2 = true;
            clickChecker++;

            if (warrior1 == true && warrior2 == true)
            {
                BtnImage12.Enabled = false;
                BtnImage3.Enabled = false;
            }
        }

        private void ClickTimerChecker_Tick(object sender, EventArgs e)
        {
            if (clickChecker >= 2)
            {
                if (king1 == true && king2 == true)
                {
                    BtnImage1.Image = Resources.King;
                    BtnImage10.Image = Resources.King;
                }
                else
                {
                    king1 = false;
                    king2 = false;

                    BtnImage1.Image = Resources.Question_mark;
                    BtnImage10.Image = Resources.Question_mark;
                }

                if (queen1 == true && queen2 == true)
                {
                    BtnImage2.Image = Resources.queen;
                    BtnImage8.Image = Resources.queen;
                }
                else
                {
                    queen1 = false;
                    queen2 = false;

                    BtnImage2.Image = Resources.Question_mark;
                    BtnImage8.Image = Resources.Question_mark;

                }

                if (peasant1 == true && peasant2 == true)
                {
                    BtnImage4.Image = Resources.peasant;
                    BtnImage6.Image = Resources.peasant;
                }
                else
                {
                    peasant1 = false;
                    peasant2 = false;

                    BtnImage4.Image = Resources.Question_mark;
                    BtnImage6.Image = Resources.Question_mark;
                }

                if (warrior1 == true && warrior2 == true)
                {
                    BtnImage3.Image = Resources.warrior;
                    BtnImage12.Image = Resources.warrior;
                }
                else
                {
                    warrior1 = false;
                    warrior2 = false;

                    BtnImage3.Image = Resources.Question_mark;
                    BtnImage12.Image = Resources.Question_mark;
                }

                if (beast1 == true && beast2 == true)
                {
                    BtnImage7.Image = Resources.Beast;
                    BtnImage9.Image = Resources.Beast;
                }
                else
                {
                    beast1 = false;
                    beast2 = false;

                    BtnImage7.Image = Resources.Question_mark;
                    BtnImage9.Image = Resources.Question_mark;
                }

                if (wizard1 == true && wizard2 == true)
                {
                    BtnImage5.Image = Resources.wizard;
                    BtnImage11.Image = Resources.wizard;
                }
                else
                {
                    wizard1 = false;
                    wizard2 = false;

                    BtnImage5.Image = Resources.Question_mark;
                    BtnImage11.Image = Resources.Question_mark;
                }

                clickChecker = 0;
            }
        }

        private void WinnerChecker_Tick(object sender, EventArgs e)
        {
            if (BtnImage1.Enabled == false &&
                BtnImage2.Enabled == false &&
                BtnImage3.Enabled == false &&
                BtnImage4.Enabled == false &&
                BtnImage5.Enabled == false &&
                BtnImage6.Enabled == false &&
                BtnImage7.Enabled == false &&
                BtnImage8.Enabled == false &&
                BtnImage9.Enabled == false &&
                BtnImage10.Enabled == false &&
                BtnImage11.Enabled == false &&
                BtnImage12.Enabled == false)
            {
                WinnerTimerChecker.Enabled = false; // Disable the timer
                MessageBox.Show("You win!");

                DialogResult result = MessageBox.Show("Do you want to restart?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    restartGame();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Thanks for playing!");
                    Environment.Exit(0);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main mainF = new Main();
            mainF.Show();
            this.Close();
        }
    }
}
