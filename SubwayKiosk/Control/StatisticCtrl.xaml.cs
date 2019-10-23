using SubKiLibrary;
using SubwayKiosk.Model.changeCategoryType;
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
        private List<Food> categoryFoodList = new List<Food>();

        public StatisticCtrl()
        {
            InitializeComponent();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            tbCategoryTitle.Text = "선택해주세요.";
            lvStatisticCategory.ItemsSource = new List<Food>();
            lvStatisticCategory.Items.Refresh();
            StatisticArgs args = new StatisticArgs();

            if (OnStatisticComplate != null)
            {
                OnStatisticComplate(this, args);
            }
        }

        public void calcTodayTotalPrice()
        {
            string total = App.statistic.ToDayTotalPrice() + " 원";
            tbTodayTotalPrice.Text = total;
        }

        private void ClickSandwich(object sender, RoutedEventArgs e)
        {
            refreshCategoryLV(Category.eCategory.Sandwich);
        }

        private void ClickChopSal(object sender, RoutedEventArgs e)
        {
            refreshCategoryLV(Category.eCategory.ChoppedSalads);
        }

        private void ClickSideAndDrink(object sender, RoutedEventArgs e)
        {
            refreshCategoryLV(Category.eCategory.SideAndDrink);
        }

        private void ClickAddToping(object sender, RoutedEventArgs e)
        {
            refreshCategoryLV(Category.eCategory.AdditionalToppings);
        }

        private void refreshCategoryLV(Category.eCategory eCategory)
        {
            CategoryType categoryType = new CategoryType();
            List<Food> foods = new List<Food>();
            tbCategoryTitle.Text = categoryType.ChangeString(eCategory);
            foods = App.statistic.CategoryFoodList(eCategory);
            lvStatisticCategory.ItemsSource = foods;
            lvStatisticCategory.Items.Refresh();
        }
    }
}
