using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SubwayKiosk.Model.ClientSocket
{
    class ClientSocket
    {
        private Socket socket = null;
        private byte[] buff = new byte[1024];

        public ClientSocket(String ip, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                socket.Connect(ip, port);
                Console.Write("Connecting");
            }
            catch(Exception)
            {
                Console.WriteLine("Fail to Connet the Server");
            }
        }

        public void SendByte(String cmd)
        {
            byte[] bcmd = Encoding.UTF8.GetBytes(cmd);

            socket.Send(bcmd);

            int n = socket.Receive(buff);

            String data = Encoding.UTF8.GetString(buff);
        }

        public void EndConnection()
        {
            socket.Close();
        }
    }
}
