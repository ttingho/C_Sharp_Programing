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
    /// OrderMenuControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderMenuControl : UserControl
    {
        public OrderMenuControl()
        {
            InitializeComponent();

            this.Loaded += OrderMenuControl_Loaded;
        }

        private void OrderMenuControl_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Load()
        {
            foreach(Model.Menu menu in App.menuData.lstMenu)
            {
                OrderMenuItemControl itemControl = new OrderMenuItemControl();
                Uri imageuri = new Uri(menu.ImagePath, UriKind.RelativeOrAbsolute);
                BitmapImage imagebitmap = new BitmapImage(imageuri);
                itemControl.img.Source = imagebitmap;
                lstOrder.Items.Add(itemControl);
            }
        }
    }
}
