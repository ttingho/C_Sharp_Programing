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
    }
}
