using System;

using System.Windows.Forms;

namespace TA_Proj
{
    public partial class Form1 : Form
    {
        private bool player1 { get; set; }
        private bool player2 { get; set; }

        private int[] roundResults = new int[2];
        private int player1Score = 0;
        private int player2Score = 0;

        public Form1()
        {
            InitializeComponent();
            nextbtn.Enabled = false;
        }

        private void printResult(int playerNumber, int result)
        {
            
            
            if (playerNumber == 1)
            {
                if (result == 0)
                {
                    player1res_lbl.Text = "Решка";
                }
                else if (result == 1)
                {
                    player1res_lbl.Text = "Орел";
                }
            }
            else if (playerNumber == 2)
            {
                if (result == 0)
                {
                    player2res_lbl.Text = "Решка";
                }
                else if (result == 1)
                {
                    player2res_lbl.Text = "Орел";
                }
            } 
        }

        private void refreshScore()
        {
            bool result = roundResults[0] != roundResults[1];

            if (result)
            {
                player2Score += 1;
            }
            else
            {
                player1Score += 1;
            }

            scorelbl.Text = player1Score + " / " + player2Score;

            if (player1Score == 2)
            {
                MessageBox.Show("Игрок 1 выиграл!", "Конец игры", MessageBoxButtons.OK);
                restartGame();
            } else if (player2Score == 2)
            {
                MessageBox.Show("Игрок 2 выиграл!", "Конец игры", MessageBoxButtons.OK);
                restartGame();
            }
        }

        private void restartGame()
        {
            player1 = false;
            player2 = false;
            player1Score = 0;
            player2Score = 0;
            player1throw.Enabled = true;
            player2throw.Enabled = true;
            nextbtn.Enabled = false;
            scorelbl.Text = "0 / 0";
            player1res_lbl.Text = "";
            player2res_lbl.Text = "";
        }

        private void player1throw_Click(object sender, EventArgs e)
        {
            Random generator = new Random();

            int coin = generator.Next(0, 2);
            player1 = true;
            roundResults[0] = coin;
            
            printResult(1,coin);
            player1throw.Enabled = false;
            if (player1 && player2)
            {
                nextbtn.Enabled = true;
                refreshScore();
            }
        }

        private void player2throw_Click_1(object sender, EventArgs e)
        {
            Random generator = new Random();

            int coin = generator.Next(0, 2);
            player2 = true;
            roundResults[1] = coin;
            
            printResult(2,coin);
            player2throw.Enabled = false;
            if (player1 && player2)
            {
                nextbtn.Enabled = true;
                refreshScore();
            }
        }

        private void Flushbtn_MouseClick(object sender, MouseEventArgs e)
        {
            restartGame();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            player1 = false;
            player2 = false;
            player1throw.Enabled = true;
            player2throw.Enabled = true;
            nextbtn.Enabled = false;
            player1res_lbl.Text = "";
            player2res_lbl.Text = "";
        }
    }
}