using SubKiLibrary;
using SubwayKiosk.Model.changeCategoryType;
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
        private CategoryType categoryType = new CategoryType();

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

        private void LvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category category = lvCategory.SelectedItem as Category;
            if (category == null) return;
            updateOrderMenu(category);

        }

        private void updateOrderMenu(Category category)
        {
            List<Food> lstOrderFoods = new List<Food>();
            foreach(Food food in App.foodData.lstMenu)
            {
                if (categoryCheck(food, category))
                {
                    lstOrderFoods.Add(food);
                }
            }
            lvOrderMenu.ItemsSource = lstOrderFoods;
            lvOrderMenu.Items.Refresh();
        }

        private bool categoryCheck(Food food, Category category)
        {
            return food.Category.Equals(categoryType.ChangeEnum(category.CategoryName));
        }
    }
}
