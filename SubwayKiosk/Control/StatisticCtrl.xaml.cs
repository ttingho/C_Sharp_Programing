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
    /// Interaction logic for StatisticCtrl.xaml
    /// </summary>
    public class StatisticArgs : EventArgs
    {
        // Something..
    }
    public partial class StatisticCtrl : UserControl
    {
        public delegate void StatisticComplateHandler(object sender, StatisticArgs args);
        public event StatisticComplateHandler OnStatisticComplate;
        public StatisticCtrl()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            StatisticArgs args = new StatisticArgs();

            if (OnStatisticComplate != null)
            {
                OnStatisticComplate(this, args);
            }
        }
    }
}
