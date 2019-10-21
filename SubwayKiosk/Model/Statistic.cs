using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubKiLibrary;

namespace SubKiLibrary
{
    public class Statistic
    {
        public List<SubkiTable> SaledFood = new List<SubkiTable>();

        private IEnumerable<Food> TotalCatagori(ObservableCollection<Food> foodList, Category.eCategory category)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Food> TotalName(ObservableCollection<Food> foodList, string name)
        {
            throw new NotImplementedException();
        }

        public int GetTotalSalesByDate(DateTime day)
        {
            DateTime nextDay = day.AddDays(1.0);
            List<SubkiTable> DateTable = SaledFood.FindAll(x => (x.date > day && x.date < nextDay));

            return DateTable.Sum(x => x.TotalPrice);
        }

        private List<Food> TotalCatagori(List<Food> foods, Category.eCategory category)
        {
            return foods.FindAll(x => x.Category == category);
        }

        private List<Food> TotalName(List<Food> foods, string name)
        {
            return foods.FindAll(x => x.EnName == name);
        }

        public int GetTotalSalesByCatagori(Category.eCategory category)
        {
            List<Food> AllFood = new List<Food>();

            foreach(SubkiTable item in SaledFood)
            {
                AllFood.AddRange(TotalCatagori(item.FoodList, category));
            }
            return AllFood.Sum(x => x.Price * x.Count);
        }

        public int GetTotalSalesByName(string name)
        {
            List<Food> AllFood = new List<Food>();

            foreach (SubkiTable item in SaledFood)
            {
                AllFood.AddRange(TotalName(item.FoodList, name));
            }
            return AllFood.Sum(x => x.Price * x.Count);
        }
    }
}
