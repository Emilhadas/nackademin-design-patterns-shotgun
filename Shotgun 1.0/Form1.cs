using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int action;
        public int round;
        public static string message;
        Score score = Score.Instance();


        private void Form1_Load(object sender, EventArgs e)
        {
            tbxYourAmmo.Text = "0";
            tbxCPUAmmo.Text = "0";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbxYourAmmo.Clear();
            tbxCPUAmmo.Clear();
            PbxHider();

            PlayerActions pA = new PlayerActions();
            CpuActions cA = new CpuActions();


            Clash clash = new Clash();
            message = clash.Fight(1);

            tbxCPUAmmo.Text = cA.GetCpuAmmo().ToString();
            ComputerAction(cA.GetAction());
            tbxYourAmmo.Text = pA.PlayerAmmunition().ToString();

            pbxLoad.Show();

            if (tbxYourAmmo.Text == "1" || tbxYourAmmo.Text == "2")
            {
                btnShoot.Show();

            }
            if (tbxYourAmmo.Text == "3")
            {
                btnShotgun.Show();

            }

            ResultFromEachRound(message);
            LossWinHandler(message);




        }


        private void btnBlock_Click(object sender, EventArgs e)
        {
            PbxHider();
            PlayerActions pA = new PlayerActions();
            CpuActions cA = new CpuActions();
            Clash clash = new Clash();
            message = clash.Fight(2);
            pbxBlock.Show();
            tbxCPUAmmo.Text = cA.GetCpuAmmo().ToString();

            ComputerAction(cA.GetAction());

            ResultFromEachRound(message);
            LossWinHandler(message);

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            tbxYourAmmo.Clear();
            tbxCPUAmmo.Clear();
            PbxHider();
            PlayerActions pA = new PlayerActions();
            CpuActions cA = new CpuActions();


            Clash clash = new Clash();
            message = clash.Fight(3);

            tbxYourAmmo.Text = pA.PlayerAmmunition().ToString();
            tbxCPUAmmo.Text = cA.GetCpuAmmo().ToString();
            ComputerAction(cA.GetAction());

            pbxShoot.Show();

            if (tbxYourAmmo.Text == "0")
            {
                btnShoot.Hide();

            }
            ResultFromEachRound(message);
            LossWinHandler(message);





        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Winner();
            PlayerActions pA = new PlayerActions();
            CpuActions cA = new CpuActions();

           
            
            pA.ScoreReset();
            cA.ScoreReset();
            lbxScoresheet.Items.Clear();
            tbxCPUAmmo.Text = "0";
            tbxYourAmmo.Text = "0";
            PbxHider();
            round = 0;
            btnShoot.Hide();
            btnShotgun.Hide();
            Enabler();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            PbxHider();
            PlayerActions pA = new PlayerActions();
            CpuActions cA = new CpuActions();
            Clash clash = new Clash();
            message = clash.Fight(4);
            pbxShoot.Show();
            tbxCPUAmmo.Text = cA.GetCpuAmmo().ToString();
            tbxYourAmmo.Text = cA.GetCpuAmmo().ToString();

            ComputerAction(cA.GetAction());

            ResultFromEachRound(message);
            LossWinHandler(message);
            if (pA.PlayerAmmunition() < 3)
            {
                btnShotgun.Hide();
            }
        }

        public void PbxHider()
        {
            pbxBlock.Hide();
            pbxLoad.Hide();
            pbxShoot.Hide();
            pbxCPUShoot.Hide();
            pbxCPUShield.Hide();
            pbxCPUReload.Hide();

        }

        public void ComputerAction(int action)
        {
            if (action == 1)
            {
                pbxCPUReload.Show();

            }
            else if (action == 2)
            {
                pbxCPUShield.Show();

            }
            else if (action == 3 || action == 4)
            {
                pbxCPUShoot.Show();

            }
        }
        public int ComputerRandom()
        {
            Random rnd = new Random();


            if (tbxCPUAmmo.Text == "0")
            {
                action = rnd.Next(1, 3);
            }
            else
            {
                action = rnd.Next(1, 4);

            }
            return action;
        }


        public void ResultFromEachRound(string msg)
        {
            Clash c = new Clash();

            round++;
            lbxScoresheet.Items.Add("Runda " + round + ": " + msg);
        }

        public void LossWinHandler(string msg)
        {
            if (msg == "You Lose")
            {
                Falsifier();
                MessageBox.Show("You lose");
            }
            if (msg == "You Win!")
            {
                Falsifier();
                MessageBox.Show("You win, good job!");
            }

        }

        public void Falsifier()
        {
            btnShotgun.Enabled = false;
            btnShoot.Enabled = false;
            btnLoad.Enabled = false;
            btnBlock.Enabled = false;
        }
        public void Enabler()
        {
            btnShotgun.Enabled = true;
            btnShoot.Enabled = true;
            btnLoad.Enabled = true;
            btnBlock.Enabled = true;

        }

        private void tbxCPU_TextChanged(object sender, EventArgs e)
        {

        }

        public void Winner()
        {
            PlayerWins.Text = score.playerScore.ToString();
            ComputerWins.Text = score.computerScore.ToString();

        }


    }
}
