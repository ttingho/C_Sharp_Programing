using SubKiLibrary;
using SubwayKiosk.Model.changeCategoryType;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class OrderArgs : EventArgs
    {
        public SubkiTable SelectedTable { get; set; }

    }
    public partial class OrderCtrl : UserControl
    {
        private List<Food> lstOrderFoods = new List<Food>();
        public SubkiTable OrderMenu = new SubkiTable();
        public SubkiTable ctrlOrderMenu = new SubkiTable();

        private CategoryType categoryType = new CategoryType();
        public delegate void OrderComplateHandler(object sender, OrderArgs args);
        public event OrderComplateHandler OnOrderComplate;

        public OrderCtrl()
        {
            Loaded += OrderCtrl_Loaded;
            InitializeComponent();
        }
        

        private void OrderCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            lvShoppingBasket.ItemsSource = OrderMenu.FoodList;
            total_price.Text = OrderMenu.TotalPrice + " 원";
            lvCategory.ItemsSource = App.categoryData.SubkiCategorys;
        }

        private void FoodList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            lvShoppingBasket.ItemsSource = ctrlOrderMenu.FoodList;
        }

        private void LvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category category = lvCategory.SelectedItem as Category;
            if (category == null) return;
            updateOrderMenu(category);

        }

        private void updateOrderMenu(Category category)
        {
            lstOrderFoods = new List<Food>();
            foreach(Food food in App.foodData.lstMenu)
            {
                if (categoryCheck(food, category))
                {
                    lstOrderFoods.Add(food.Clone());
                }
            }
            lvOrderMenu.ItemsSource = lstOrderFoods;
            lvOrderMenu.Items.Refresh();
        }

        private bool categoryCheck(Food food, Category category)
        {
            return food.Category.Equals(categoryType.ChangeEnum(category.CategoryName));
        }

        private void Button_Click_Add_Order(object sender, RoutedEventArgs e)
        {
            OrderArgs args = new OrderArgs();
            args.SelectedTable = ctrlOrderMenu.Clone();
            OrderMenu = new SubkiTable();
            ctrlOrderMenu = new SubkiTable();
            lvShoppingBasket.ItemsSource = new List<Food>();
            total_price.Text = "0 원";
            lvCategory.Items.Refresh();
            lvOrderMenu.Items.Refresh();
            lvShoppingBasket.Items.Refresh();
            if (OnOrderComplate != null)
            {
                OnOrderComplate(this, args);
            }
        }

        private void Button_Click_Cancel_Order(object sender, RoutedEventArgs e)
        {
            OrderArgs args = new OrderArgs();
            ctrlOrderMenu = new SubkiTable();

            args.SelectedTable = OrderMenu.Clone();
            
            lvShoppingBasket.ItemsSource = new List<Food>();
            total_price.Text = "0 원";
            lvCategory.Items.Refresh();
            lvOrderMenu.Items.Refresh();
            lvShoppingBasket.Items.Refresh();

            if (OnOrderComplate != null)
            {
                OnOrderComplate(this, args);
            }
        }

        private void Button_Click_Plus_Menu(object sender, RoutedEventArgs e)
        {
            Food food = ((ListViewItem)lvOrderMenu.ContainerFromElement(sender as Button)).Content as Food;
            if (food == null) return;

            var item = ctrlOrderMenu.FoodList.Where(x => x.KrName.Equals(food.KrName)).FirstOrDefault();
            if (item == null)
            {
                food.Count = 1;
                ctrlOrderMenu.TotalPrice += food.Clone().Price;
                ctrlOrderMenu.FoodList.Add(food.Clone());
                total_price.Text = ctrlOrderMenu.TotalPrice + " 원";
            }
            else
            {
                item.Count++;
                total_price.Text = ctrlOrderMenu.TotalPrice + " 원";
            }
            lvShoppingBasket.ItemsSource = ctrlOrderMenu.FoodList;
            lvShoppingBasket.Items.Refresh();
        }

        private void Button_Click_Minus_Menu(object sender, RoutedEventArgs e)
        {
            Food food = ((ListViewItem)lvOrderMenu.ContainerFromElement(sender as Button)).Content as Food;
            if (food == null) return;

            var item = ctrlOrderMenu.FoodList.Where(x => x.KrName.Equals(food.KrName)).FirstOrDefault();
            if(item == null)
            {
                return;
            }
            item.Count--;

            if (item.Count == 0)
            {
                ctrlOrderMenu.FoodList.Remove(item);
                lvShoppingBasket.Items.Refresh();
                total_price.Text = ctrlOrderMenu.TotalPrice + " 원";
                return;
            }
            else
            {
                total_price.Text = ctrlOrderMenu.TotalPrice + " 원";
            }
            lvShoppingBasket.ItemsSource = ctrlOrderMenu.FoodList;
            lvShoppingBasket.Items.Refresh();
        }
    }
}
