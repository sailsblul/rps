using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rps
{
    public partial class rps : Form
    {
        int wins = 0;
        int losses = 0;
        int draws = 0;
        int choice = 0;
        bool winStreak;
        int streak = 0;
        int vel = 0;
        double[] count = new double[3] { 0, 0, 0 };
        Random cpu = new Random();

        public rps()
        {
            InitializeComponent();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            count[choice] += 1;
            lblRocks.Text = $"Rock: {count[0]} ({Math.Round(count[0] / (count[0] + count[1] + count[2]) * 100, 2)}%)";
            lblPapers.Text = $"Paper: {count[1]} ({Math.Round(count[1] / (count[0] + count[1] + count[2]) * 100, 2)}%)";
            lblScissors.Text = $"Scissors: {count[2]} ({Math.Round(count[2] / (count[0] + count[1] + count[2]) * 100, 2)}%)";
            btnFight.Enabled = false;
            grpWeapons.Enabled = false;
            int cpuChoice = cpu.Next(0, 3);
            switch (cpuChoice)
            {
                case 0:
                    imgCom.Image = Properties.Resources.rock;
                    break;
                case 1:
                    imgCom.Image = Properties.Resources.paper;
                    break;
                case 2:
                    imgCom.Image = Properties.Resources.scissors;
                    break;
            }
            imgCom.Visible = true;
            vel = 0;
            imgCom.Top = -239;
            tmrAnimate.Enabled = true;
            lblResult.Visible = true;
            if (choice == cpuChoice)
            {
                lblResult.Text = "Draw";
                draws += 1;
                lblDraws.Text = $"Draws: {draws}";
            }
            else if ((choice+1)%3 == cpuChoice)
            {
                lblResult.Text = "Computer Wins!";
                losses += 1;
                lblLosses.Text = $"Losses: {losses}";
                if (winStreak || streak == 0)
                {
                    streak = 1;
                    lblStreak.Text = "Streak: 1 loss";
                    winStreak = false;
                }
                else
                {
                    streak += 1;
                    lblStreak.Text = $"Streak: {streak} losses";
                }
            }
            else
            {
                lblResult.Text = "You Win!";
                wins += 1;
                lblWins.Text = $"Wins: {wins}";
                if (winStreak)
                {
                    streak += 1;
                    lblStreak.Text = $"Streak: {streak} wins";
                }
                else
                {
                    streak = 1;
                    lblStreak.Text = $"Streak: 1 win";
                    winStreak = true;
                }
            }
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            choice = 0;
            imgPlayer.Image = Properties.Resources.rock;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            choice = 1;
            imgPlayer.Image = Properties.Resources.paper;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            choice = 2;
            imgPlayer.Image = Properties.Resources.scissors;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            btnAgain.Visible = false;
            btnFight.Enabled = true;
            grpWeapons.Enabled = true;
            lblResult.Visible = false;
            imgCom.Visible = false;
            tmrAnimate.Enabled = false;
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            imgCom.Top += vel;
            vel += 1;
            if (imgCom.Top >= 12)
            {
                if (vel == 1)
                {
                    tmrAnimate.Enabled = false;
                    btnAgain.Visible = true;
                }
                else
                {
                    vel = vel / 2 * -1;
                }
            }
        }

    }
}
