using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlämmningsuppgift2
{

    public partial class Form1 : Form
    {
        //Ramis kommentar

        bool gameOver = false;
        int roundTimer = 6;

        string[] computerList = {"ladda", "blocka", "skjuta"};
        int randomNumber = 1;
        Random rndNumber = new Random();

        string computerChoice;
        string playerChoice;

        int playerAmmo;
        int computerAmmo;



        public Form1()
        {
            InitializeComponent();

            countDown.Enabled = true;
            lableCountDown.Text = "5";
            btnShotgun.Enabled = false;
            btnSkjut.Enabled = false;
        }

        public void restart()
        {
            playerAmmo = 0;
            computerAmmo = 0;

            lablePlayerAmmo.Text = "Ammo: " + playerAmmo;
            labelComputerAmmo.Text = "Ammo: " + computerAmmo;

            countDown.Enabled = true;

            pictureBox1.Image = Properties.Resources.question_mark;
            pictureBox2.Image = Properties.Resources.question_mark;

            gameOver = false;
            btnShotgun.Enabled = false;
            btnSkjut.Enabled = false;
            startNextRound();
        }

        private void startNextRound()
        {
            if (gameOver)
            {
                return;
            }

            lablePlayerAmmo.Text = "Ammo: " + playerAmmo;
            labelComputerAmmo.Text = "Ammo: " + computerAmmo;

            countDown.Enabled = true;

            pictureBox1.Image = Properties.Resources.question_mark;
            pictureBox2.Image = Properties.Resources.question_mark;
        }


        private void btnLadda_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.loading;
            playerChoice = "ladda";
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.shield;
            playerChoice = "blocka";
        }

        private void btnSkjut_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.handgun;
            playerChoice = "skjuta";
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            playerChoice = "shotgun";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void countDownTime(object sender, EventArgs e)
        {
            roundTimer -= 1;
            lableCountDown.Text = roundTimer.ToString();

            if (roundTimer < 1)
            {
                countDown.Enabled = false;
                roundTimer = 5;
                randomNumber = rndNumber.Next(0, 3);
                if (computerAmmo > 1)
                {
                    computerChoice = computerList[randomNumber];
                }
                else
                {
                    computerChoice = computerList[0];
                }

                switch (computerChoice)
                {
                    case "ladda":
                        pictureBox2.Image = Properties.Resources.loading;

                        break;
                    case "blocka":
                        pictureBox2.Image = Properties.Resources.shield;

                        break;
                    case "skjuta":
                        pictureBox2.Image = Properties.Resources.handgun;

                        break;
                }
                checkGame();
            }

        }

        private void checkGame()
        {
            if (playerChoice == "ladda" && computerChoice == "skjuta")
            {
                gameOver = true;
                MessageBox.Show("Datorn vinner");
            }
            else if (playerChoice == "blocka" && computerChoice == "skjuta")
            {
                computerAmmo--;
                MessageBox.Show("Dator förlorar skott");
            }
            else if (playerChoice == "skjuta" && computerChoice == "skjuta")
            {
                playerAmmo--;
                computerAmmo--;
                MessageBox.Show("Båda förlorar skott");
            }

            else if (playerChoice == "ladda" && computerChoice == "ladda")
            {
                computerAmmo++;
                playerAmmo++;
                MessageBox.Show("Båda får skott");
            }
            else if (playerChoice == "ladda" && computerChoice == "blocka")
            {
                playerAmmo++;
                MessageBox.Show("Spelare får skott");
            }
            else if (playerChoice == "blocka" && computerChoice == "blocka")
            {
                MessageBox.Show("Inget händer");
            }
            else if (playerChoice == "blocka" && computerChoice == "ladda")
            {
                computerAmmo++;
                MessageBox.Show("Dator får skott");
            }
            else if (playerChoice == "skjuta" && computerChoice == "blocka")
            {
                playerAmmo--;
                MessageBox.Show("Spelare förlorar skott");
            }
            else if (playerChoice == "skjuta" && computerChoice == "ladda")
            {
                gameOver = true;
                MessageBox.Show("Spelare vinner");
            }
            else if (computerChoice == "skjuta" && playerChoice == "ladda")
            {
                gameOver = true;
                MessageBox.Show("Datorn vinner");
            }

            if (computerAmmo >= 4)
            {
                gameOver = true;
                MessageBox.Show("Shotgun, Datorn vinner");
            }
            if (playerChoice == "shotgun")
            {
                gameOver = true;
                MessageBox.Show("Shotgun, Spelaren vinner");
            }


            if (playerAmmo >= 3)
            {
                btnShotgun.Enabled = true;
            }
            else
            {
                btnShotgun.Enabled = false;
            }

            if (playerAmmo >= 1)
            {
                btnSkjut.Enabled = true;
            }
            else
            {
                btnSkjut.Enabled = false;
            }

            startNextRound();
        }
    }
}
