﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubKiLibrary;

namespace SubKiLibrary
{
    public class Statistic
    {
        public List<SubkiTable> SaledFood = new List<SubkiTable>();

        public List<Food> CategoryFoodList(Category.eCategory eCategory)
        {
            List<Food> categoryFoods = new List<Food>();

            foreach (SubkiTable table in SaledFood)
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
