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
    public class Client
    {
        public static Socket _socket;
        public static byte[] buffer = new byte[1024];
        public static void Sock()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public static void Connect(string ipAddress)
        {
            _socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ipAddress), 8000), ConnectCallBack, null);
        }
        public static void ConnectCallBack(IAsyncResult result)
        {
            buffer = new byte[1024];
            _socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, RecieveCallBack, null);
            Form1.iType = 4;
            Form1.Type = 2;

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
