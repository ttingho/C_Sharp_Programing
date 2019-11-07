using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubKiLibrary;

namespace SubwayKiosk.Model
{
    public class FoodData
    {
        public bool isLoaded = false;
        public List<Food> lstMenu = null;

        public void Load()
        {
            if (isLoaded)
            {
                return;
            }

            if (lstMenu != null)
            {
                return;
            }

            lstMenu = new List<Food>()
            {
                new Food(){ KrName = "쉬림프 SW", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg", Category = Category.eCategory.Sandwich, Price = 4300 },
                new Food(){ KrName = "쉬림프 아보카도 SW", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg", Category = Category.eCategory.Sandwich, Price = 4300},
                new Food(){ KrName = "로티세리 바비큐 치킨 SW", EnName = "Rotisserie Barbecue Chicken", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich, Price = 4300},
                new Food(){ KrName = "풀드포크 SW", EnName = "Pulled Pork", ImagePath = @"\Assets\SUBWAY_Sand\subway_004.jpg", Category = Category.eCategory.Sandwich, Price = 4300 },
                new Food(){ KrName = "에그마요 SW", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.Sandwich, Price = 4700},
                new Food(){ KrName = "이탈리안 비엠티 SW", EnName = "Italian B.M.T.", ImagePath = @"\Assets\SUBWAY_Sand\subway_006.jpg", Category = Category.eCategory.Sandwich, Price = 4700},
                new Food(){ KrName = "비엘티 SW", EnName = "B.L.T.", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.Sandwich, Price = 4700 },
                new Food(){ KrName = "미트볼 SW", EnName = "Meatball", ImagePath = @"\Assets\SUBWAY_Sand\subway_008.jpg", Category = Category.eCategory.Sandwich, Price = 4700 },
                new Food(){ KrName = "햄 SW", EnName = "Ham", ImagePath = @"\Assets\SUBWAY_Sand\subway_009.jpg", Category = Category.eCategory.Sandwich, Price = 5100},
                new Food(){ KrName = "참치 SW", EnName = "Tuna", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.Sandwich, Price = 5100 },
                new Food(){ KrName = "로스트 치킨 SW", EnName = "Roasted Chicken", ImagePath = @"\Assets\SUBWAY_Sand\subway_011.jpg", Category = Category.eCategory.Sandwich, Price = 5100 },
                new Food(){ KrName = "로스트 비프 SW", EnName = "Roasted Beef", ImagePath = @"\Assets\SUBWAY_Sand\subway_012.jpg", Category = Category.eCategory.Sandwich, Price = 5100 },
                new Food(){ KrName = "써브웨이 클럽 SW", EnName = "Subway Club", ImagePath = @"\Assets\SUBWAY_Sand\subway_013.jpg", Category = Category.eCategory.Sandwich, Price = 5500 },
                new Food(){ KrName = "터키 SW", EnName = "Turkey", ImagePath = @"\Assets\SUBWAY_Sand\subway_014.jpg", Category = Category.eCategory.Sandwich, Price = 5500 },
                new Food(){ KrName = "베지 SW", EnName = "Veggie Delite", ImagePath = @"\Assets\SUBWAY_Sand\subway_015.jpg", Category = Category.eCategory.Sandwich, Price = 5500 },
                new Food(){ KrName = "스테이크 & 치즈 SW", EnName = "Steak & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_016.jpg", Category = Category.eCategory.Sandwich, Price = 5500 },
                new Food(){ KrName = "터키 베이컨 아보카도 SW", EnName = "Turkey Bacon Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_017.jpg", Category = Category.eCategory.Sandwich, Price = 5900 },
                new Food(){ KrName = "치킨 베이컨 랜치 SW", EnName = "Chicken & Bacon Ranch", ImagePath = @"\Assets\SUBWAY_Sand\subway_018.jpg", Category = Category.eCategory.Sandwich, Price = 5900 },
                new Food(){ KrName = "써브웨이 멜트 SW", EnName = "Subway Melt", ImagePath = @"\Assets\SUBWAY_Sand\subway_019.jpg", Category = Category.eCategory.Sandwich, Price = 5900 },
                new Food(){ KrName = "터키 베이컨 SW", EnName = "Turkey Bacon", ImagePath = @"\Assets\SUBWAY_Sand\subway_020.jpg", Category = Category.eCategory.Sandwich, Price = 5900 },
                new Food(){ KrName = "스파이시 이탈리안 SW", EnName = "Spicy Italian", ImagePath = @"\Assets\SUBWAY_Sand\subway_021.jpg", Category = Category.eCategory.Sandwich, Price = 5900 },
                new Food(){ KrName = "치킨 데리야끼 SW", EnName = "Chicken Teriyaki", ImagePath = @"\Assets\SUBWAY_Sand\subway_022.jpg", Category = Category.eCategory.Sandwich, Price = 6300 },
                new Food(){ KrName = "블랙 햄 & 에그, 치즈 SW", EnName = "Black Ham & Egg, Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_023.jpg", Category = Category.eCategory.Sandwich, Price = 6300},
                new Food(){ KrName = "웨스턴, 에그 & 치즈 SW", EnName = "Western, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_024.jpg", Category = Category.eCategory.Sandwich, Price = 6300 },
                new Food(){ KrName = "베이컨, 에그 & 치즈 SW", EnName = "Bacon, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_025.jpg", Category = Category.eCategory.Sandwich, Price = 6300 },
                new Food(){ KrName = "스테이크, 에그 & 치즈 SW", EnName = "Steak, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_026.jpg", Category = Category.eCategory.Sandwich, Price = 6300 },
                new Food(){ KrName = "더블업", EnName = "Double Up", ImagePath = @"\Assets\SUBWAY_toping\subway_001.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700},
                new Food(){ KrName = "베이컨 비츠", EnName = "Bacon Bits", ImagePath = @"\Assets\SUBWAY_toping\subway_002.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700 },
                new Food(){ KrName = "쉬림프 더블업", EnName = "Shrimp Double Up", ImagePath = @"\Assets\SUBWAY_toping\subway_003.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700 },
                new Food(){ KrName = "에그마요", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_toping\subway_004.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700 },
                new Food(){ KrName = "오믈렛", EnName = "Omelet", ImagePath = @"\Assets\SUBWAY_toping\subway_005.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700 },
                new Food(){ KrName = "아보카도", EnName = "Avocado", ImagePath = @"\Assets\SUBWAY_toping\subway_006.jpg", Category = Category.eCategory.AdditionalToppings, Price = 1700 },
                new Food(){ KrName = "베이컨", EnName = "Bacon", ImagePath = @"\Assets\SUBWAY_toping\subway_007.jpg", Category = Category.eCategory.AdditionalToppings, Price = 2000},
                new Food(){ KrName = "페퍼로니", EnName = "Pepperoni", ImagePath = @"\Assets\SUBWAY_toping\subway_008.jpg", Category = Category.eCategory.AdditionalToppings, Price = 2000 },
                new Food(){ KrName = "더블 치즈", EnName = "Double Cheese", ImagePath = @"\Assets\SUBWAY_toping\subway_009.jpg", Category = Category.eCategory.AdditionalToppings, Price = 2000 },
                new Food(){ KrName = "웨지 포테이토", EnName = "Ovenbaked Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_001.jpg", Category = Category.eCategory.SideAndDrink, Price = 2500 },
                new Food(){ KrName = "치즈 웨지 포테이토", EnName = "Cheesy Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_002.jpg", Category = Category.eCategory.SideAndDrink, Price = 2500 },
                new Food(){ KrName = "베이컨 치즈 웨지 포테이토", EnName = "Bacon Cheesy Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_003.jpg", Category = Category.eCategory.SideAndDrink, Price = 3000},
                new Food(){ KrName = "브로콜리 체다 수프", EnName = "Broccoli Cheddar Soup", ImagePath = @"\Assets\SUBWAY_Side\subway_004.jpg", Category = Category.eCategory.SideAndDrink, Price = 3500 },
                new Food(){ KrName = "베이크 포테이토 수프", EnName = "Baked Potato Soup", ImagePath = @"\Assets\SUBWAY_Side\subway_005.jpg", Category = Category.eCategory.SideAndDrink, Price = 3500 },
                new Food(){ KrName = "더블 초코칩 쿠키", EnName = "Double Chocolate Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_006.jpg", Category = Category.eCategory.SideAndDrink, Price = 3500 },
                new Food(){ KrName = "초코칩 쿠키", EnName = "Chocolate Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_007.jpg", Category = Category.eCategory.SideAndDrink, Price = 2400 },
                new Food(){ KrName = "오트밀 레이즌", EnName = "Oatmeal Raisin", ImagePath = @"\Assets\SUBWAY_Side\subway_008.jpg", Category = Category.eCategory.SideAndDrink, Price = 2400 },
                new Food(){ KrName = "라즈베리 치즈케이크", EnName = "Raspberry Cheese Cake", ImagePath = @"\Assets\SUBWAY_Side\subway_009.jpg", Category = Category.eCategory.SideAndDrink, Price = 3000 },
                new Food(){ KrName = "칩", EnName = "Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_010.jpg", Category = Category.eCategory.SideAndDrink, Price = 2800},
                new Food(){ KrName = "탄산음료", EnName = "Soda", ImagePath = @"\Assets\SUBWAY_Side\subway_011.jpg", Category = Category.eCategory.SideAndDrink, Price = 2800 },
                new Food(){ KrName = "커피", EnName = "Coffee", ImagePath = @"\Assets\SUBWAY_Side\subway_012.jpg", Category = Category.eCategory.SideAndDrink, Price = 3000 },
                new Food(){ KrName = "해쉬브라운", EnName = "Hash Brown", ImagePath = @"\Assets\SUBWAY_Side\subway_013.jpg", Category = Category.eCategory.SideAndDrink, Price = 2400 },
                new Food(){ KrName = "쉬림프 CS", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sal\subway_001.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "쉬림프 아보카도 CS", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sal\subway_002.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "로티세리 치킨 CS", EnName = "Rotisserie Chicken", ImagePath = @"\Assets\SUBWAY_Sal\subway_003.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "풀드포크 CS", EnName = "Pulled Pork", ImagePath = @"\Assets\SUBWAY_Sal\subway_004.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "이탈리안 비엠티 CS", EnName = "Italian B.M.T.", ImagePath = @"\Assets\SUBWAY_Sal\subway_005.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "비엘티 CS", EnName = "B.L.T.", ImagePath = @"\Assets\SUBWAY_Sal\subway_006.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "미트볼 CS", EnName = "Meatball", ImagePath = @"\Assets\SUBWAY_Sal\subway_007.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "햄 CS", EnName = "Ham", ImagePath = @"\Assets\SUBWAY_Sal\subway_008.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "참치 CS", EnName = "Tuna", ImagePath = @"\Assets\SUBWAY_Sal\subway_009.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4400 },
                new Food(){ KrName = "에그마요 CS", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_Sal\subway_010.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4500 },
                new Food(){ KrName = "로스트 치킨 CS", EnName = "Roasted Chicken", ImagePath = @"\Assets\SUBWAY_Sal\subway_011.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "로스트 비프 CS", EnName = "Roasted Beef", ImagePath = @"\Assets\SUBWAY_Sal\subway_012.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4200 },
                new Food(){ KrName = "써브웨이 클럽 CS", EnName = "Subway Club", ImagePath = @"\Assets\SUBWAY_Sal\subway_013.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "터키 CS", EnName = "Turkey", ImagePath = @"\Assets\SUBWAY_Sal\subway_014.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4500 },
                new Food(){ KrName = "베지 CS", EnName = "Veggie Delite", ImagePath = @"\Assets\SUBWAY_Sal\subway_015.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "스테이크 & 치즈 CS", EnName = "Steak & Cheese", ImagePath = @"\Assets\SUBWAY_Sal\subway_016.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4500 },
                new Food(){ KrName = "터키 베이컨 아보카도 CS", EnName = "Turkey Bacon Avocado", ImagePath = @"\Assets\SUBWAY_Sal\subway_017.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4400 },
                new Food(){ KrName = "치킨 베이컨 랜치 CS", EnName = "Chicken & Bacon Ranch", ImagePath = @"\Assets\SUBWAY_Sal\subway_018.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4000 },
                new Food(){ KrName = "써브웨이 멜트 CS", EnName = "Subway Melt", ImagePath = @"\Assets\SUBWAY_Sal\subway_019.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4400 },
                new Food(){ KrName = "터키 베이컨 CS", EnName = "Turkey Bacon", ImagePath = @"\Assets\SUBWAY_Sal\subway_020.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4300 },
                new Food(){ KrName = "스파이시 이탈리안 CS", EnName = "Spicy Italian", ImagePath = @"\Assets\SUBWAY_Sal\subway_021.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4400 },
                new Food(){ KrName = "치킨 데리야끼 CS", EnName = "Chicken Teriyaki", ImagePath = @"\Assets\SUBWAY_Sal\subway_022.jpg", Category = Category.eCategory.ChoppedSalads, Price = 4500 },

            };
        }

        public List<Food> GetFoods(Category.eCategory category)
        {
            List<Food> result = new List<Food>();
            foreach (Food item in lstMenu)
            {
                if (item.Category == category)
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
