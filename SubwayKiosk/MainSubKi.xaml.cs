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
using SubKiLibrary;


namespace SubwayKiosk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainSubKi : Window
    {
        public MainSubKi()
        {
            InitializeComponent();
            Loaded += MainSubKi_Loaded;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString();
        }

        private void MainSubKi_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("MainSubki_Loaded");
            App.foodData.Load();
            App.tableData.Load();
#if true
            //lvMain.ItemsSource = App.foodData.lstMenu;
            lvTable.ItemsSource = App.tableData.SubkiTables;
#else
            LoadMenu();
#endif
        }

        private void LvTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Food> lstSandwichFoods = new List<Food>();
            List<Food> lstChoppedSaladFoods = new List<Food>();
            List<Food> lstSideAndDrinks = new List<Food>();
            List<Food> lstToppings = new List<Food>();
            foreach (Food food in ((SubkiTable)(lvTable.SelectedItem)).FoodList)
            {
                if (food.Category == Category.eCategory.Sandwich)
                {
                    lstSandwichFoods.Add(food);
                }

                if (food.Category == Category.eCategory.ChoppedSalads)
                {
                    lstChoppedSaladFoods.Add(food);
                }

                if (food.Category == Category.eCategory.SideAndDrink)
                {
                    lstSideAndDrinks.Add(food);
                }

                if (food.Category == Category.eCategory.AdditionalToppings)
                {
                    lstToppings.Add(food);
                }
            }
            lvSandwich.ItemsSource = lstSandwichFoods;
            lvChoppedSalad.ItemsSource = lstChoppedSaladFoods;
            lvSideAndDrink.ItemsSource = lstSideAndDrinks;
            lvTopping.ItemsSource = lstToppings;

            lvSandwich.Items.Refresh();
            lvChoppedSalad.Items.Refresh();
            lvSideAndDrink.Items.Refresh();
            lvTopping.Items.Refresh();

            ResetMenuSelection();
        }

        private void ResetMenuSelection()
        {
            lvSandwich.SelectedIndex = -1;
            lvChoppedSalad.SelectedIndex = -1;
            lvSideAndDrink.SelectedIndex = -1;
            lvTopping.SelectedIndex = -1;
        }

        private void Add_Order_Button_Click(object sender, RoutedEventArgs e)
        {
            mainSubki_contents.Visibility = Visibility.Collapsed;
            order_ctrl.Visibility = Visibility.Visible;
        }
    }
}
