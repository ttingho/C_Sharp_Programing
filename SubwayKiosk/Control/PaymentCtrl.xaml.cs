using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static SubKiLibrary.Payment;

namespace SubwayKiosk.Control
{
    /// <summary>
    /// Interaction logic for PaymentCtrl.xaml
    /// </summary>
    
    public class PaymentArgs : EventArgs
    {
        public SubkiTable PaymentTable { get; set; }

    }

    public partial class PaymentCtrl : UserControl
    {
        public delegate void PaymentComplateHandler(object sender, PaymentArgs args);
        public event PaymentComplateHandler OnPaymentComplate;
        public SubkiTable ctrlPaymentTable = new SubkiTable();
        public SubkiTable paymentTable = new SubkiTable();
        public ePayment payment = new ePayment();
        public PaymentCtrl()
        {
            InitializeComponent();
        }

        private void PaymentCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            lvOrderMenu.ItemsSource = paymentTable.FoodList;
            paymentTotalPrice.Text = paymentTable.TotalPrice + "원";
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            PaymentArgs args = new PaymentArgs();
            ctrlPaymentTable = new SubkiTable();
            
            args.PaymentTable = paymentTable.Clone();

            lvOrderMenu.ItemsSource = new List<Food>();
            paymentTotalPrice.Text = "0원";
            payment = ePayment.empty;

            if (paymentCtrl_selected_payment.Visibility == Visibility.Collapsed)
            {
                paymentCtrl_selected_payment.Visibility = Visibility.Visible;
                paymentCtrl_confirmation.Visibility = Visibility.Collapsed;
            }

            if (OnPaymentComplate != null)
            {
                OnPaymentComplate(this, args);
            }
        }

        private void Cash_Button_Click(object sender, RoutedEventArgs e)
        {
            lvOrderMenu.ItemsSource = paymentTable.FoodList;
            paymentTotalPrice.Text = paymentTable.TotalPrice + "원";
            lvOrderMenu.Items.Refresh();
            payment_title.Text = "결제 하시겠습니까?";
            payment = ePayment.Cash;
            paymentCtrl_selected_payment.Visibility = Visibility.Collapsed;
            paymentCtrl_confirmation.Visibility = Visibility.Visible;
        }

        private void Card_Button_Click(object sender, RoutedEventArgs e)
        {
            lvOrderMenu.ItemsSource = paymentTable.FoodList;
            paymentTotalPrice.Text = paymentTable.TotalPrice + "원";
            payment_title.Text = "결제 하시겠습니까?";
            payment = ePayment.Card;
            paymentCtrl_selected_payment.Visibility = Visibility.Collapsed;
            paymentCtrl_confirmation.Visibility = Visibility.Visible;
        }

        private void Payment_Confirmation_Button_Click(object sender, RoutedEventArgs e)
        {
            PaymentArgs args = new PaymentArgs();

            ctrlPaymentTable.date = DateTime.Now;
            ctrlPaymentTable.Payment = payment;
            ctrlPaymentTable.isPayed = true;

            App.statistic.SaledFood.Add(ctrlPaymentTable.Clone());

            args.PaymentTable = new SubkiTable() { Idx = ctrlPaymentTable.Idx, TotalPrice = 0, Payment = ePayment.empty, FoodList = new ObservableCollection<Food>() };

            lvOrderMenu.ItemsSource = new List<Food>();
            ctrlPaymentTable = new SubkiTable();
            paymentTable = new SubkiTable();
            paymentTotalPrice.Text = "0원";

            if (paymentCtrl_selected_payment.Visibility == Visibility.Collapsed)
            {
                paymentCtrl_selected_payment.Visibility = Visibility.Visible;
                paymentCtrl_confirmation.Visibility = Visibility.Collapsed;
            }

            if (OnPaymentComplate != null)
            {
                OnPaymentComplate(this, args);
            }
        }
    }
}
