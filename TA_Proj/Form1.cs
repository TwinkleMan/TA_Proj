using System;

using System.Windows.Forms;

namespace TA_Proj
{
    public partial class Form1 : Form
    {
        private bool player1 { get; set; }  //походил ли игрок 1
        private bool player2 { get; set; }  //походил ли игрок 2

        private int[] roundResults = new int[2];    //результаты раунда
        private int player1Score = 0;   //счет игрока 1 за игру
        private int player2Score = 0;   //счет игрока 2 за игру

        public Form1()
        {
            InitializeComponent();
            nextbtn.Enabled = false;
        }

        private void printResult(int playerNumber, int result)
        {

            //вывод результатов броска на экран в зависимости от значения стороны монеты result и номера игрока playerNumber
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

        private void refreshScore()     //вывод на экран итогового счета (в конце раунда)
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

            if (player1Score == 2)  //завершение игры если кто-либо из игроков выиграл 2 раунда
            {
                MessageBox.Show("Игрок 1 выиграл!", "Конец игры", MessageBoxButtons.OK);
                restartGame();
            } else if (player2Score == 2)
            {
                MessageBox.Show("Игрок 2 выиграл!", "Конец игры", MessageBoxButtons.OK);
                restartGame();
            }
        }

        private void restartGame()      //перезапуск игры
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

        private void player1throw_Click(object sender, EventArgs e)     //игрок1 "бросает" монету
        {
            Random generator = new Random();

            int coin = generator.Next(0, 2);    //"подбрасываем" монету
            player1 = true;     //отмечаем, что игрок1 походил
            roundResults[0] = coin;     //сохраняем результаты броска
            
            printResult(1,coin);    //вывод результатов
            player1throw.Enabled = false;   //блокируем кнопку броска для данного игрока
            if (player1 && player2)     //проверяем можно ли завершить раунд (т.е. бросили ли оба игрока монету)
            {
                nextbtn.Enabled = true;     //разблокируем кнопку следующего раунда
                refreshScore();     //подсчитываем очки
            }
        }

        private void player2throw_Click_1(object sender, EventArgs e)   //игрок2 "бросает" монету
        {
            //идентичен предыдущему методу
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

        private void Flushbtn_MouseClick(object sender, MouseEventArgs e)   //перезапуск игры
        {
            restartGame();
        }

        private void nextbtn_Click(object sender, EventArgs e)      //переход к следующему раунду
        {
            //возвращаем переменные в исходные значения
            player1 = false;
            player2 = false;
            player1throw.Enabled = true;
            player2throw.Enabled = true;
            nextbtn.Enabled = false;
            //стираем результаты текущего броска для каждого игрока
            player1res_lbl.Text = "";
            player2res_lbl.Text = "";
        }
    }
}