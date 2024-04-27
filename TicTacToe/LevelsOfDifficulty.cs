using System;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class Form1
    {

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
            //iType = 3;

            //RestartGame();

            this.Hide();
            ClientServer clientServer = new ClientServer();
            clientServer.Show();
        }
    }
}
