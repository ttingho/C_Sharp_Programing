using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class TableData
    {
        public bool isLoaded = false;
        public List<SubkiTable> SubkiTables { get; set; }
        private ObservableCollection<Food> lstOrderFoodData = new ObservableCollection<Food>();
    public void Load()
        {
            if (isLoaded)
            {
                return;
            }

            SubkiTables = new List<SubkiTable>()
            {
                new SubkiTable() { Idx = 1, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
                new SubkiTable() { Idx = 2, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
                new SubkiTable() { Idx = 3, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
                new SubkiTable() { Idx = 4, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
                new SubkiTable() { Idx = 5, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
                new SubkiTable() { Idx = 6, TotalPrice = 0, Payment = Payment.ePayment.empty, FoodList = new ObservableCollection<Food>() },
            };

            isLoaded = true;
        }
    }
}
