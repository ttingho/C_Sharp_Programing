using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SubKiLibrary.Payment;

namespace SubKiLibrary
{
    public class SubkiTable
    {
        public int Idx { get; set; }
        public List<Food> FoodList { get; set; }
        public int TotalPrice { get; set; }
        public ePayment Payment { get; set; }
        public bool isPayed = false;
        public DateTime date;

        public SubkiTable()
        {
            FoodList = new List<Food>();
            date = DateTime.Now;
        }

        public void AddFood(Food food)
        {
            this.FoodList.Add(food);
        }

        public void RemoveAllFood()
        {
            this.FoodList = new List<Food>();
        }

        public void RemoveFood(Food food)
        {
            this.FoodList.Remove(food);
        }

        public void ReviseFood(Food food, int Count)
        {
            this.FoodList.Find(x => x.Equals(food)).Count = Count;
        }

        public void CalcTotalPrice()
        {
            int result = 0;
            foreach (Food item in FoodList)
            {
                result += item.Price * item.Count;
            }

            TotalPrice = result;
        }

        public void Pay()
        {
            if (isPayed) return;
            Statistic.SaledFood.Add(this);
            this.isPayed = true;
        }
    }
}
