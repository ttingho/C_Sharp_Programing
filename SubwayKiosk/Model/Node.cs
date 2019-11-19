using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace SubwayKiosk.Model
{
    public class Node
    {
        public String ip = "10.80.163.138";
        public int port = 80;

        private Thread client = null;

        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private String msg = null;
        private String allmsg = null;

        private byte[] rcBuff = new byte[4096];

        public bool isConnected = false;

        public String id = "@2209";

        public String startTime = null;
        public String endTime = null;

        public String strError = null;
        private bool logout = false;

        public void run()
        {
            try
            {
                login();
                Success();
                StartTimer();

                while(true)
                {
                    if (this.logout){
                        this.logout = false;
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                        return;
                    }
                    if(this.msg != null)
                    {
                        Send();
                        Success();
                    }
                    if(this.allmsg != null)
                    {
                        SendAll();
                        Success();
                    }
                }
            }
            catch(Exception e)
            {
                EndTimer();
                this.socket.Close();
                isConnected = false;
                this.strError = string.Format("[SYSTEM] : {0}", e.Message);
                this.Connect();
            }
        }

        public void Connect()
        {
            try
            {
                this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.socket.Connect(ip, port);
            }
            catch (Exception e)
            {
                this.strError = string.Format("[SYSTEM] : {0}", e.Message);
                return;
            }

            this.isConnected = true;

            client = new Thread(new ThreadStart(run));
            client.IsBackground = true;
            client.Start();
        }

        private void login()
        {
            socket.Send(ToBytes(this.id));
        }

        private byte[] ToBytes(String cmd)
        {
            return Encoding.UTF8.GetBytes(cmd);
        }

        private int ReciveData()
        {
            int n = socket.Receive(this.rcBuff);

            String data = Encoding.UTF8.GetString(this.rcBuff, 0, n);

            return Int32.Parse(data);
        }

        private bool Success()
        {
            if (ReciveData() == 200)
                return true;
            return false;
        }

        private void Send()
        {
            socket.Send(ToBytes(this.id + "#" + this.msg));
            this.msg = null;
        }

        private void SendAll()
        {
            socket.Send(ToBytes("@All" + "#" + this.allmsg));
            this.allmsg = null;
        }

        private void StartTimer()
        {
            startTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        private void EndTimer()
        {
            endTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        public void setMessage(String msg)
        {
            if (msg.Contains("#") || msg == "") return;
            this.msg = msg;
        }

        public void setMessageAll(String msg)
        {
            if (msg.Contains("#") || msg == "") return;
            this.allmsg = msg;
        }

        public void setID(int id)
        {
            this.id = "@" + id.ToString();
        }
        
        public void disconnected()
        {
            this.logout = true;
        }
    }
}
