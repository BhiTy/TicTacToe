using System;
using System.Drawing;
using System.Windows.Forms;
using BotLogics;
using ButtonBackgroundImage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public BotLogic botLogic;
        public ToolStrip myToolStrip;

        /// <summary>
        /// <para>Позиция данных TicTacToe</para>
        /// <para>0|1|2</para>
        /// <para>3|4|5</para>
        /// <para>6|7|8</para>
        /// </summary>
        public static int[] iData = new int[9];

        //-1 = X, 1 = O, 0 = Стоп
        public int iTurn = -1;

        //0 = Легко, 1 = Средне, 2 = Невозможно, 3 = Играть против друга
        public static int iType = 1;

        public static int Type;

        public bool bEnableBot = false;

        //Сохранение позиции последнего хода
        public static int iLastMove = -1;

        public int iXScores = 0;
        public int iOScores = 0;

        public ClientServer clientServer = new ClientServer();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "Начните игру или выберите игрока";
            botLogic = new BotLogic(this);
            BackgroundImage backgroundImage0 = new BackgroundImage(button1, button2, button3, button4, button5, button6, button7, button8, button9);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        public void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Levels.Text = "Легко";
            iType = 0;

            RestartGame();
        }

        public void medateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Levels.Text = "Средне";
            iType = 1;

            RestartGame();
        }

        public void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Levels.Text = "Сложно";
            iType = 2;

            RestartGame();
        }

        public void playAgainstAFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Levels.Text = "Играть против друга";
            RestartGame();
            this.Close();
            clientServer.Show();
        }

        public void Game(int iType, int iLastMove, int[] iData)
        {
            var background = new ButtonBackground();

            if (iType == 0 || iType == 1 || iType == 2 || iType == 3)
            {
                background.ChangeButtonBackgroundImage(iLastMove, iData);
            }
            else if (iType == 4)
            {
                ClCheck();
            }
        }

        public void RestartGame()
        {
            //Сбросить данные
            for (int i = 0; i <= 8; i++)
            {
                iData[i] = 0;
            }

            iLastMove = -1;
            bEnableBot = false;
            //Х сначала
            iTurn = 1;
            SetNextTurn();

            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;

            panel4.Visible = false;
            panel5.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[0] == 0)
            {
                iLastMove = 0;
                iData[0] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[1] == 0)
            {
                iLastMove = 1;
                iData[1] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[2] == 0)
            {
                iLastMove = 2;
                iData[2] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[3] == 0)
            {
                iLastMove = 3;
                iData[3] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[4] == 0)
            {
                iLastMove = 4;
                iData[4] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[5] == 0)
            {
                iLastMove = 5;
                iData[5] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[6] == 0)
            {
                iLastMove = 6;
                iData[6] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[7] == 0)
            {
                iLastMove = 7;
                iData[7] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[8] == 0)
            {
                iLastMove = 8;
                iData[8] = iTurn;
                Game(iType, iLastMove, iData);
                SetNextTurn();
                botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
            }
        }

        //Кнопка перезагрузки
        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        //Верхние 2 кнопки
        private void button11_Click(object sender, EventArgs e)
        {
               
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (iType == 3 || iLastMove != -1)
                return;

            botLogic.RunBot(iType, iTurn, bEnableBot, iLastMove, iData);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        public void SetNextTurn()
        {
            int iGameStatus = CheckGameStatus();
            if (iGameStatus == 2)
            {
                if (iTurn == -1)
                {
                    iTurn = 1;
                    label1.Text = "                 𐩒 ходит";
                    panel2.Visible = false;
                    panel3.Visible = true;
                }
                else
                {
                    if (iType != 3 && iLastMove == -1)
                    {
                        iTurn = -1;
                        label1.Text = "Начните игру или выберите игрока";
                        panel2.Visible = true;
                        panel3.Visible = false;
                    }
                    else
                    {
                        iTurn = -1;
                        label1.Text = "                 🗙 ходит";
                        panel2.Visible = true;
                        panel3.Visible = false;
                    }
                }
            }
            else
            {
                if (iGameStatus == -1)
                {
                    iXScores++;
                    button11.Text = "🗙                   " + iXScores.ToString();
                    label1.Text = "                 Победил Х";
                }
                else if (iGameStatus == 1)
                {
                    iOScores++;
                    button12.Text = "𐩒                   " + iOScores.ToString();
                    label1.Text = "                 Победил 𐩒";
                }
                else
                {
                    label1.Text = "                 Ничья";
                }
                iTurn = 0;
            }
        }

        private void Line(Color color)
        {
            using (Graphics graphics = CreateGraphics())
            {
                Pen pen = new Pen(color, 5); // цвет линии и ширина
                Point p1 = new Point(216, 20); // первая точка
                Point p2 = new Point(401, 223); // вторая точка
                graphics.DrawLine(pen, p1, p2); // рисуем линию
            }
        }

        //Возврат -1 = победа X, 0 = ничья, 1 = победа O, 2 = продолжать
        public int CheckGameStatus()
        {
            // -
            if (iData[0] != 0 && iData[0] == iData[1] && iData[1] == iData[2])
            {
                panel4.Location = new System.Drawing.Point(202, 51);
                if (iData[0] == -1) panel4.BackColor = ColorTranslator.FromHtml("#666666");
                else    panel4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel4.Visible = true;
                return iData[0];
            }
            else if (iData[3] != 0 && iData[3] == iData[4] && iData[4] == iData[5])
            {
                panel4.Location = new System.Drawing.Point(202, 125);
                if (iData[3] == -1) panel4.BackColor = ColorTranslator.FromHtml("#666666");
                else panel4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel4.Visible = true;
                return iData[3];
            }
            else if (iData[6] != 0 && iData[6] == iData[7] && iData[7] == iData[8])
            {
                panel4.Location = new System.Drawing.Point(202, 190);
                if (iData[6] == -1) panel4.BackColor = ColorTranslator.FromHtml("#666666");
                else panel4.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel4.Visible = true;
                return iData[6];
            }
            // |
            else if (iData[0] != 0 && iData[0] == iData[3] && iData[3] == iData[6])
            {
                panel5.Location = new System.Drawing.Point(245, 6);
                if (iData[0] == -1) panel5.BackColor = ColorTranslator.FromHtml("#666666");
                else panel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel5.Visible = true;
                return iData[0];
            }
            else if (iData[1] != 0 && iData[1] == iData[4] && iData[4] == iData[7])
            {
                panel5.Location = new System.Drawing.Point(311, 6);
                if (iData[1] == -1) panel5.BackColor = ColorTranslator.FromHtml("#666666");
                else panel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel5.Visible = true;
                return iData[1];
            }
            else if (iData[2] != 0 && iData[2] == iData[5] && iData[5] == iData[8])
            {
                panel5.Location = new System.Drawing.Point(378, 6);
                if (iData[2] == -1) panel5.BackColor = ColorTranslator.FromHtml("#666666");
                else panel5.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                panel5.Visible = true;
                return iData[2];
            }
            // \
            else if (iData[0] != 0 && iData[0] == iData[4] && iData[4] == iData[8])
            {
                //if (iData[0] == -1) Line(ColorTranslator.FromHtml("#666666"));
                //else Line(Color.White);
                return iData[0];
            }
            // /
            else if (iData[2] != 0 && iData[2] == iData[4] && iData[4] == iData[6])
            {
                return iData[2];
            }

            else if (iData[0] != 0 && iData[1] != 0 && iData[2] != 0 && iData[3] != 0 && iData[4] != 0 && iData[5] != 0 && iData[6] != 0 && iData[7] != 0 && iData[8] != 0)
            {
                return 0;
            }

            return 2;
        }

        public void CheckWinAndDontLose(int turn)
        {
            if (iData[0] == 0 && ((iData[1] == turn && iData[2] == turn) || (iData[3] == turn && iData[6] == turn) || (iData[4] == turn && iData[8] == turn)))
                iLastMove = 0;
            else if (iData[1] == 0 && ((iData[0] == turn && iData[2] == turn) || (iData[4] == turn && iData[7] == turn)))
                iLastMove = 1;
            else if (iData[2] == 0 && ((iData[0] == turn && iData[1] == turn) || (iData[5] == turn && iData[8] == turn) || (iData[4] == turn && iData[6] == turn)))
                iLastMove = 2;
            else if (iData[3] == 0 && ((iData[0] == turn && iData[6] == turn) || (iData[4] == turn && iData[5] == turn)))
                iLastMove = 3;
            else if (iData[4] == 0 && ((iData[0] == turn && iData[8] == turn) || (iData[2] == turn && iData[6] == turn) || (iData[1] == turn && iData[7] == turn) || (iData[3] == turn && iData[5] == turn)))
                iLastMove = 4;
            else if (iData[5] == 0 && ((iData[2] == turn && iData[8] == turn) || (iData[3] == turn && iData[4] == turn)))
                iLastMove = 5;
            else if (iData[6] == 0 && ((iData[0] == turn && iData[3] == turn) || (iData[7] == turn && iData[8] == turn) || (iData[2] == turn && iData[4] == turn)))
                iLastMove = 6;
            else if (iData[7] == 0 && ((iData[1] == turn && iData[4] == turn) || (iData[6] == turn && iData[8] == turn)))
                iLastMove = 7;
            else if (iData[8] == 0 && ((iData[2] == turn && iData[5] == turn) || (iData[6] == turn && iData[7] == turn) || (iData[0] == turn && iData[4] == turn)))
                iLastMove = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}