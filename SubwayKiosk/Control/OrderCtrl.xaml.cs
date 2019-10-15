using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace SubwayKiosk.Control
{
    /// <summary>
    /// Interaction logic for OrderCtrl.xaml
    /// </summary>
    public partial class OrderCtrl : UserControl
    {
        public OrderCtrl()
        {
            Loaded += OrderCtrl_Loaded;
            InitializeComponent();
        }

        private void OrderCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("OrderCtrl_Loaded");

            lvCategory.ItemsSource = App.categoryData.SubkiCategorys;
        }
    }
}
