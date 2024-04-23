using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace Clients
{
    public class Buttons
    {
        public static Button Button1;
        public static Button Button2;
        public static Button Button3;
        public static Button Button4;
        public static Button Button5;
        public static Button Button6;
        public static Button Button7;
        public static Button Button8;
        public static Button Button9;

        public Buttons(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            Button1 = button1;
            Button2 = button2;
            Button3 = button3;
            Button4 = button4;
            Button5 = button5;
            Button6 = button6;
            Button7 = button7;
            Button8 = button8;
            Button9 = button9;

        }
    }

    public class Client
    {
        public static Socket _socket;
        public static byte[] buffer = new byte[1024];
        public static void Sock()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static void Connect(string ipAddress, int port)
        {
            _socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAddress), port), ConnectCallBack, null);
        }
        public static void ConnectCallBack(IAsyncResult result)
        {
            if (_socket.Connected)
            {
                MessageBox.Show("Вы подключились к серверу", "Подключен к серверу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buffer = new byte[1024];
                _socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RecieveCallBack, null);
                ClientServer clientServer = new ClientServer();
                clientServer.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }

        }
        public static void RecieveCallBack(IAsyncResult result)
        {
            try
            {
                int bufferSize = _socket.EndReceive(result);
                byte[] packet = new byte[bufferSize];
                Array.Copy(buffer, packet, packet.Length);
                string theMessageToReceive = Encoding.ASCII.GetString(packet);
                buffer = new byte[1024];
                _socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RecieveCallBack, null);
            }
            catch { }
        }
        public void check()
        {
        }
    }
}
