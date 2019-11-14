using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubKiLibrary;
using SubwayKiosk.Model.changeCategoryType;

namespace SubKiLibrary
{
    public class Statistic
    {
        public List<SubkiTable> SaledFood = new List<SubkiTable>();
        private CategoryType categoryType = new CategoryType();

        // 카테고리의 메뉴별 통계
        public List<Food> CategoryFoodList(Category.eCategory eCategory)
        {
            List<Food> categoryFoods = new List<Food>();

            foreach(SubkiTable table in SaledFood)
            {
                foreach(Food food in table.FoodList)
                {
                    if (food.Category == eCategory)
                    {
                        if(categoryFoods.Where(x=> x.KrName.Equals(food.KrName)).FirstOrDefault() == null)
                        {
                            food.totalPrice = food.Count * food.Price;
                            categoryFoods.Add(food.Clone());
                        }
                        else
                        {
                            var item = categoryFoods.Where(x => x.KrName.Equals(food.KrName)).FirstOrDefault();
                            item.Count += food.Count;

                            item.totalPrice = item.Count * food.Price;
                        }
                    }
                }
            }

            return categoryFoods;
        }

        // 카테고리별 통계
        public List<Category> GetCategories(List<Category> categories)
        {
            foreach (Category category in categories)
            {
                int tPrice = 0;
                foreach (SubkiTable table in SaledFood)
                {
                    foreach (Food food in table.FoodList)
                    {
                        var type = categoryType.ChangeEnum(category.CategoryName);
                        if (type == Category.eCategory.AllMenu)
                        {
                            category.totalCount += food.Count;
                            tPrice += (food.Count * food.Price);
                        }
                        else if (type == food.Category)
                        {
                            category.totalCount += food.Count;
                            tPrice += (food.Count * food.Price);
                        }
                    }
                }
                category.totalPrice = tPrice;
            }
            return categories;
        }

        public int ToDayTotalPrice()
        {
            if(SaledFood.Count == 0)
            {
                return 0;
            }
            else
            {
                int totalPrice = 0;
                String today = String.Format("yyyy.MM.dd", DateTime.Today); 
                foreach(SubkiTable table in SaledFood)
                {
                    String tableDate = String.Format("yyyy.MM.dd", table.date);
                    if(tableDate == today)
                    {
                        totalPrice += table.TotalPrice;
                    }
                }
                return totalPrice;
            }
        }
    }
}
