using SubKiLibrary;
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

namespace SubwayKiosk
{
    /// <summary>
    /// Interaction logic for FoodCtrl.xaml
    /// </summary>
    public partial class FoodCtrl : UserControl
    {
        Food food = new Food();

        public FoodCtrl()
        {
            InitializeComponent();
        }

        public void SetItem(string name, int price)
        {

        }

        public void SetItem(Food item)
        {
            food = item;
            updateItem();
        }

        public void updateItem()
        {
            FoodImage.Source = new BitmapImage(new Uri(food.ImagePath, UriKind.Relative));
            tbName.Text = food.KrName;
            tbPrice.Text = food.Price.ToString() + "원";
            tbCount.Text = food.Count.ToString() + "개";
        }
    }
}
