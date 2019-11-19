using SubwayKiosk.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SubwayKiosk.Control
{
    /// <summary>
    /// Interaction logic for LoginCtrl.xaml
    /// </summary>
    public class LoginArgs : EventArgs
    {
        public bool isLoginType { get; set; }

    }
    public partial class LoginCtrl : UserControl
    {
        public delegate void LoginComplateHandler(object sender, LoginArgs args);
        public event LoginComplateHandler OnLoginComplate;

        public LoginCtrl()
        {
            InitializeComponent();
            resetLoginInfo("10.80.163.138", 80);
        }

        private void handleLogin(object sender, RoutedEventArgs e)
        {
            LoginArgs args = new LoginArgs();

            string id = userId.Text;
            string ipAddress = serverIP.Text;
            int port = int.Parse(serverPort.Text);

            if (String.IsNullOrWhiteSpace(id) || String.IsNullOrWhiteSpace(ipAddress))
            {
                MessageBox.Show("로그인 정보를 제대로 입력 후 다시 시도해주세요.");
                return;
            }

            App.node.id = "@" + id;
            App.node.ip = ipAddress;
            App.node.port = port;

            App.node.Connect();

            if(!App.node.isConnected)
            {
                MessageBox.Show("연결에 실패했습니다.");
                return;
            }

            resetLoginInfo(ipAddress, port);

            args.isLoginType = true;

            if (OnLoginComplate != null)
            {
                OnLoginComplate(this, args);
            }
        }

        private void handleGuestLogin(object sender, RoutedEventArgs e)
        {
            LoginArgs args = new LoginArgs();

            args.isLoginType = false;

            if (OnLoginComplate != null)
            {
                OnLoginComplate(this, args);
            }
        }

        private void resetLoginInfo(string ip, int port)
        {
            userId.Text = "";
            serverIP.Text = ip;
            serverPort.Text = port.ToString();
        }
    }
}
