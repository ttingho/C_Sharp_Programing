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
using SubwayKiosk.Control;

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
            order_ctrl.OnOrderComplate += OrderCtrl_OnOrderComplate;
            payment_ctrl.OnPaymentComplate += PaymentCtrl_OnPaymentComplate;
            statistic_ctrl.OnStatisticComplate += StatisticCtrl_OnStatisticComplate;
        }

        private void StatisticCtrl_OnStatisticComplate(object sender, StatisticArgs args)
        {
            mainSubki_contents.Visibility = Visibility.Visible;
            statistic_ctrl.Visibility = Visibility.Collapsed;
        }

        private void OrderCtrl_OnOrderComplate(object sender, OrderArgs args)
        {
            mainSubki_contents.Visibility = Visibility.Visible;
            order_ctrl.Visibility = Visibility.Collapsed;
            for (int i = 0; i < App.tableData.SubkiTables.Count; i++)
            {
                if (args.SelectedTable.Idx == App.tableData.SubkiTables[i].Idx)
                {
                    App.tableData.SubkiTables[i] = args.SelectedTable;
                    int temp = lvTable.SelectedIndex;
                    lvTable.ItemsSource = App.tableData.SubkiTables;
                    lvTable.Items.Refresh();
                    lvTable.SelectedIndex = temp;
                    Replace_OrderMenuList();
                    return;
                }
            }
        }

        private void PaymentCtrl_OnPaymentComplate(object sender, PaymentArgs args)
        {
            mainSubki_contents.Visibility = Visibility.Visible;
            payment_ctrl.Visibility = Visibility.Collapsed;
            for (int i = 0; i < App.tableData.SubkiTables.Count; i++)
            {
                if (args.PaymentTable.Idx == App.tableData.SubkiTables[i].Idx)
                {
                    App.tableData.SubkiTables[i] = args.PaymentTable;
                    int temp = lvTable.SelectedIndex;
                    lvTable.ItemsSource = App.tableData.SubkiTables;
                    lvTable.Items.Refresh();
                    lvTable.SelectedIndex = temp;
                    Replace_OrderMenuList();
                    return;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dClock.Text = DateTime.Now.ToString();
        }

        private void MainSubKi_Loaded(object sender, RoutedEventArgs e)
        {
            lvTable.ItemsSource = App.tableData.SubkiTables;
        }

        private void LvTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Replace_OrderMenuList();

            ResetMenuSelection();
        }

        private void Replace_OrderMenuList()
        {
            List<Food> lstSandwichFoods = new List<Food>();
            List<Food> lstChoppedSaladFoods = new List<Food>();
            List<Food> lstSideAndDrinks = new List<Food>();
            List<Food> lstToppings = new List<Food>();

            if(lvTable.SelectedItem == null)
            {
                return;
            }
            foreach (Food food in ((SubkiTable)lvTable.SelectedItem).FoodList)
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
            if (lvTable.SelectedItem != null)
            {
                var Table = (SubkiTable)lvTable.SelectedItem;
                order_ctrl.ctrlOrderMenu = Table.Clone();

                order_ctrl.lvShoppingBasket.ItemsSource = order_ctrl.ctrlOrderMenu.FoodList;
                order_ctrl.OrderMenu = Table.Clone();
                order_ctrl.lvShoppingBasket.Items.Refresh();
                mainSubki_contents.Visibility = Visibility.Collapsed;
                order_ctrl.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("테이블을 선택해 주세요.");
            }
        }

        private void Payment_Button_Click(object sender, RoutedEventArgs e)
        {
            var Table = (SubkiTable)lvTable.SelectedItem;

            if (Table == null)
            {
                MessageBox.Show("테이블을 선택해 주세요.");
            }
            else  if (Table.FoodList.Count == 0)
            {
                MessageBox.Show("테이블에 메뉴가 추가되지 않았습니다.");
            }
            else
            {
                payment_ctrl.ctrlPaymentTable = Table.Clone();
                payment_ctrl.paymentTable = Table.Clone();
                mainSubki_contents.Visibility = Visibility.Collapsed;
                payment_ctrl.Visibility = Visibility.Visible;
            }
        }

        private void Statistic_Button_Click(object sender, RoutedEventArgs e)
        {
            mainSubki_contents.Visibility = Visibility.Collapsed;
            statistic_ctrl.Visibility = Visibility.Visible;
        }
    }
}
