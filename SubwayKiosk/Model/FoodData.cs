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
                new Food(){ KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Rotisserie Barbecue Chicken", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "풀드포크", EnName = "Pulled Pork", ImagePath = @"\Assets\SUBWAY_Sand\subway_004.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "에그마요", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "이탈리안 비엠티", EnName = "Italian B.M.T.", ImagePath = @"\Assets\SUBWAY_Sand\subway_006.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "비엘티", EnName = "B.L.T.", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "미트볼", EnName = "Meatball", ImagePath = @"\Assets\SUBWAY_Sand\subway_008.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "햄", EnName = "Ham", ImagePath = @"\Assets\SUBWAY_Sand\subway_009.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "참치", EnName = "Tuna", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "로스트 치킨", EnName = "Roasted Chicken", ImagePath = @"\Assets\SUBWAY_Sand\subway_011.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "로스트 비프", EnName = "Roasted Beef", ImagePath = @"\Assets\SUBWAY_Sand\subway_012.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "써브웨이 클럽", EnName = "Subway Club", ImagePath = @"\Assets\SUBWAY_Sand\subway_013.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "터키", EnName = "Turkey", ImagePath = @"\Assets\SUBWAY_Sand\subway_014.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "베지", EnName = "Veggie Delite", ImagePath = @"\Assets\SUBWAY_Sand\subway_015.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "스테이크 & 치즈", EnName = "Steak & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_016.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "터키 베이컨 아보카도", EnName = "Turkey Bacon Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_017.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "치킨 베이컨 랜치", EnName = "Chicken & Bacon Ranch", ImagePath = @"\Assets\SUBWAY_Sand\subway_018.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "써브웨이 멜트", EnName = "Subway Melt", ImagePath = @"\Assets\SUBWAY_Sand\subway_019.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "터키 베이컨", EnName = "Turkey Bacon", ImagePath = @"\Assets\SUBWAY_Sand\subway_020.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "스파이시 이탈리안", EnName = "Spicy Italian", ImagePath = @"\Assets\SUBWAY_Sand\subway_021.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "치킨 데리야끼", EnName = "Chicken Teriyaki", ImagePath = @"\Assets\SUBWAY_Sand\subway_022.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "블랙 포레스트햄, 에그, 치즈", EnName = "Black Forest Ham & Egg, Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_023.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "웨스턴, 에그 & 치즈", EnName = "Western, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_024.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "베이컨, 에그 & 치즈", EnName = "Bacon, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_025.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "스테이크, 에그 & 치즈", EnName = "Steak, Egg & Cheese", ImagePath = @"\Assets\SUBWAY_Sand\subway_026.jpg", Category = Category.eCategory.Sandwich },
                new Food(){ KrName = "더블업", EnName = "Double Up", ImagePath = @"\Assets\SUBWAY_toping\subway_001.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "베이컨 비츠", EnName = "Bacon Bits", ImagePath = @"\Assets\SUBWAY_toping\subway_002.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "쉬림프 더블업", EnName = "Shrimp Double Up", ImagePath = @"\Assets\SUBWAY_toping\subway_003.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "에그마요", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_toping\subway_004.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "오믈렛", EnName = "Omelet", ImagePath = @"\Assets\SUBWAY_toping\subway_005.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "아보카도", EnName = "Avocado", ImagePath = @"\Assets\SUBWAY_toping\subway_006.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "베이컨", EnName = "Bacon", ImagePath = @"\Assets\SUBWAY_toping\subway_007.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "페퍼로니", EnName = "Pepperoni", ImagePath = @"\Assets\SUBWAY_toping\subway_008.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "더블 치즈", EnName = "Double Cheese", ImagePath = @"\Assets\SUBWAY_toping\subway_009.jpg", Category = Category.eCategory.AdditionalToppings },
                new Food(){ KrName = "웨지 포테이토", EnName = "Ovenbaked Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_001.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "치즈 웨지 포테이토", EnName = "Cheesy Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_002.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "베이컨 치즈 웨지 포테이토", EnName = "Bacon Cheesy Wedge Potatoes", ImagePath = @"\Assets\SUBWAY_Side\subway_003.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "브로콜리 체타 수프", EnName = "Broccoli Cheddar Soup", ImagePath = @"\Assets\SUBWAY_Side\subway_004.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "베이크 포테이토 수프", EnName = "Baked Potato Soup", ImagePath = @"\Assets\SUBWAY_Side\subway_005.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "더블 초코칩 쿠키", EnName = "Double Chocolate Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_006.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "초코칩 쿠키", EnName = "Chocolate Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_007.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "오트밀 레이즌", EnName = "Oatmeal Raisin", ImagePath = @"\Assets\SUBWAY_Side\subway_008.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "라즈베리 치즈케이크", EnName = "Raspberry Cheese Cake", ImagePath = @"\Assets\SUBWAY_Side\subway_009.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "칩", EnName = "Chip", ImagePath = @"\Assets\SUBWAY_Side\subway_010.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "탄산음료", EnName = "Soda", ImagePath = @"\Assets\SUBWAY_Side\subway_011.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "커피", EnName = "Coffee", ImagePath = @"\Assets\SUBWAY_Side\subway_012.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "해쉬브라운", EnName = "Hash Brown", ImagePath = @"\Assets\SUBWAY_Side\subway_013.jpg", Category = Category.eCategory.SideAndDrink },
                new Food(){ KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sal\subway_001.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sal\subway_002.jpg", Category = Category.eCategory.ChoppedSalads},
                new Food(){ KrName = "로티세리 치킨", EnName = "Rotisserie Chicken", ImagePath = @"\Assets\SUBWAY_Sal\subway_003.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "풀드포크", EnName = "Pulled Pork", ImagePath = @"\Assets\SUBWAY_Sal\subway_004.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "이탈리안 비엠티", EnName = "Italian B.M.T.", ImagePath = @"\Assets\SUBWAY_Sal\subway_005.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "비엘티", EnName = "B.L.T.", ImagePath = @"\Assets\SUBWAY_Sal\subway_006.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "미트볼", EnName = "Meatball", ImagePath = @"\Assets\SUBWAY_Sal\subway_007.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "햄", EnName = "Ham", ImagePath = @"\Assets\SUBWAY_Sal\subway_008.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "참치", EnName = "Tuna", ImagePath = @"\Assets\SUBWAY_Sal\subway_009.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "에그마요", EnName = "Egg Mayo", ImagePath = @"\Assets\SUBWAY_Sal\subway_010.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "로스트 치킨", EnName = "Roasted Chicken", ImagePath = @"\Assets\SUBWAY_Sal\subway_011.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "로스트 비프", EnName = "Roasted Beef", ImagePath = @"\Assets\SUBWAY_Sal\subway_012.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "써브웨이 클럽", EnName = "Subway Club", ImagePath = @"\Assets\SUBWAY_Sal\subway_013.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "터키", EnName = "Turkey", ImagePath = @"\Assets\SUBWAY_Sal\subway_014.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "베지", EnName = "Veggie Delite", ImagePath = @"\Assets\SUBWAY_Sal\subway_015.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "스테이크 & 치즈", EnName = "Steak & Cheese", ImagePath = @"\Assets\SUBWAY_Sal\subway_016.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "터키 베이컨 아보카도", EnName = "Turkey Bacon Avocado", ImagePath = @"\Assets\SUBWAY_Sal\subway_017.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "치킨 베이컨 랜치", EnName = "Chicken & Bacon Ranch", ImagePath = @"\Assets\SUBWAY_Sal\subway_018.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "써브웨이 멜트", EnName = "Subway Melt", ImagePath = @"\Assets\SUBWAY_Sal\subway_019.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "터키 베이컨", EnName = "Turkey Bacon", ImagePath = @"\Assets\SUBWAY_Sal\subway_020.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "스파이시 이탈리안", EnName = "Spicy Italian", ImagePath = @"\Assets\SUBWAY_Sal\subway_021.jpg", Category = Category.eCategory.ChoppedSalads },
                new Food(){ KrName = "치킨 데리야끼", EnName = "Chicken Teriyaki", ImagePath = @"\Assets\SUBWAY_Sal\subway_022.jpg", Category = Category.eCategory.ChoppedSalads },

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
