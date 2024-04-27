using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servers;
using Clients;
using TicTacToe;
using Games;
using ButtonBackgroundImage;

namespace TicTacToe
{
    public partial class ClientServer : Form
    {
        public ClientServer()
        {
            InitializeComponent();
            Servers.Server.sock();
            Clients.Client.Sock();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void Back_Click(object sender, EventArgs e)
        {
            if (Servers.Server.serverCreated)
            {
                Servers.Server.Close();
            }
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void Local_Click(object sender, EventArgs e)
        {
            Form1.iType = 3;
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Back.Location = new Point(117, 46);
            Local.Visible = false;
            Client.Visible = false;
            Server.Visible = false;
            ipAdress.Visible = true;
            ipBox.Visible = true;
            Create.Visible = true;
            this.Size = new Size(208, 79);
            CloseButton.Location = new Point(190, 0);
        }

        public void Create_Click(object sender, EventArgs e)
        {
            if (!Servers.Server.serverCreated)
            {
                Servers.Server.Bind(ipBox.Text.ToString());
                Servers.Server.Listen(500);
                Servers.Server.Accept();
                Check1();
            }
        }

        private void Client_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            Back.Location = new Point(117, 46);
            Local.Visible = false;
            Client.Visible = false;
            Server.Visible = false;
            ipAdress.Visible = true;
            ipBox.Visible = true;
            Connect.Visible = true;
            this.Size = new Size(208, 79);
            CloseButton.Location = new Point(190, 0);
        }
        public void Check1()
        {
            Form1 clientServer1 = new Form1();
            this.Hide();
            clientServer1.Show();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            Clients.Client.Connect(ipBox.Text.ToString());
            Check1();
        }

        Point lastPoint;
        private void ClientServer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ClientServer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
