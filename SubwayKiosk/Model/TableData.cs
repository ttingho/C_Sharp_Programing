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
                new Food(){ KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg", Category = Category.eCategory.Sandwich, Count = 2 },
                new Food(){ KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Count = 1 },
                new Food(){ KrName = "풀드포크", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_004.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "미트볼", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_006.jpg", Category = Category.eCategory.ChoppedSalads, Count = 1 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "커피", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "탄산음료", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_008.jpg", Category = Category.eCategory.SideAndDrink, Count = 2 },
                new Food(){ KrName = "베이컨 비츠", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_009.jpg", Category = Category.eCategory.AdditionalToppings, Count = 1 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
                new Food(){ KrName = "더블업", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.AdditionalToppings, Count = 2 },
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
