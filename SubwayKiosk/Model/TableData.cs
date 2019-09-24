using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class TableData
    {
        public bool isLoaded = false;
        public List<SubkiTable> SubkiTables { get; set; }
        private List<Food> lstOrderFoodData = new List<Food>()
            {
                new Food() { KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg"},
                new Food() { KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg"},
                new Food() { KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg"},
                new Food() { KrName = "로스트 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg"},
            };
    public void Load()
        {
            if (isLoaded)
            {
                return;
            }

            SubkiTables = new List<SubkiTable>()
            {
                new SubkiTable() { Idx = 1, TotalPrice = 12000, Payment = Payment.ePayment.Cash, FoodList = lstOrderFoodData },
                new SubkiTable() { Idx = 2, TotalPrice = 20000, Payment = Payment.ePayment.Card, FoodList = lstOrderFoodData },
                new SubkiTable() { Idx = 3, TotalPrice = 15000, Payment = Payment.ePayment.Card, FoodList = lstOrderFoodData },
                new SubkiTable() { Idx = 4, TotalPrice = 10000, Payment = Payment.ePayment.Cash, FoodList = lstOrderFoodData },
                new SubkiTable() { Idx = 5, TotalPrice = 8000, Payment = Payment.ePayment.Cash, FoodList = lstOrderFoodData },
                new SubkiTable() { Idx = 6, TotalPrice = 4500, Payment = Payment.ePayment.Card, FoodList = lstOrderFoodData },
            };

            isLoaded = true;
        }
    }
}
