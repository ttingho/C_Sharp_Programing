using SubKiLibrary;
using SubwayKiosk.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SubwayKiosk
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public static FoodData foodData = new FoodData();
        public static TableData tableData = new TableData();
        public static CategoryData categoryData = new CategoryData();
        public static Statistic statistic = new Statistic();
        public static Node node = new Node();
        public static bool loginType = false;

        public App()
        {
            App.node.dc += new HandleDisconnect(handleDisconnectedMessage);
            App.node.dc += new HandleDisconnect(App.node.Connect);
        }

        private void handleDisconnectedMessage()
        {
            MessageBox.Show("서버와의 연결이 끊어졌습니다.");
        }
    }
}
