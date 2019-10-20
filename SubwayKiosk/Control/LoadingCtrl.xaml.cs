using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace SubwayKiosk.Control
{
    /// <summary>
    /// Interaction logic for LoadingCtrl.xaml
    /// </summary>
    public partial class LoadingCtrl : UserControl
    {
        public LoadingCtrl()
        {
            InitializeComponent();
            Loading();
        }

        private async void Loading()
        {
            App.categoryData.Load();
            App.foodData.Load();
            App.tableData.Load();
            await Task.Delay(3000);
            this.Visibility = Visibility.Collapsed;
        }
    }
}
