using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using TicTacToe;

namespace Servers
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

    public class Server
    {
        public static Socket _socket;
        public static Socket clientSocket;
        public static byte[] buffer = new byte[1024];
        public static bool serverCreated = false;

        public static void sock()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static void Bind(string ipAdress)
        {
            _socket.Bind(new IPEndPoint(IPAddress.Parse(ipAdress.ToString()), 8000));
            serverCreated = true;
            MessageBox.Show("Ожидание второго игрока", "Сервер создан", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.iType = 4;
            Form1.Type = 1;
        }
        public static void Close()
        {
            _socket.Close();
        }
        public static void Listen(int backlog)
        {
            _socket.Listen(backlog);
        }
        public static void Accept()
        {
            _socket.BeginAccept(AcceptCallBack, null);
        }
        public static void AcceptCallBack(IAsyncResult result)
        {
            clientSocket = _socket.EndAccept(result);
            buffer = new byte[1024];
            Accept();
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RecieveCallBack, clientSocket);
        }
        public static void RecieveCallBack(IAsyncResult result)
        {
            clientSocket = result.AsyncState as Socket;
            int bufferSize = clientSocket.EndReceive(result);
            byte[] packet = new byte[bufferSize];
            Array.Copy(buffer, packet, packet.Length);
            string msg = Encoding.ASCII.GetString(packet);
            buffer = new byte[1024];
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RecieveCallBack, clientSocket);
        }
    }
}
