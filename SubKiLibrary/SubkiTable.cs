using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SubKiLibrary.Payment;

namespace SubKiLibrary
{
    public class SubkiTable
    {
        public int Idx { get; set; }
        public ObservableCollection<Food> FoodList;
        private int _totalPrice;
        public int TotalPrice 
        {
            get
            {
                CalcTotalPrice();
                return _totalPrice;
            }
            set => _totalPrice = value;
        }
        public ePayment Payment { get; set; }
        public bool isPayed = false;
        public DateTime date;


        public SubkiTable()
        {
            date = DateTime.Now;
            FoodList = new ObservableCollection<Food>();
        }

        public void AddFood(Food food)
        {
            this.FoodList.Add(food.Clone());
        }

        public void RemoveAllFood()
        {
            this.FoodList = new ObservableCollection<Food>();
        }

        public void RemoveFood(Food food)
        {
            this.FoodList.Remove(food);
        }

        public void ReviseFood(Food food, int Count)
        {
            //this.FoodList.Find(x => x.Equals(food)).Count = Count;
        }

        public void CalcTotalPrice()
        {
            int result = 0;

            foreach (Food item in FoodList)
            {
                result += item.Price * item.Count;
            }

            _totalPrice = result;
        }

        public void Pay()
        {
            if (isPayed) return;
            //Statistic.SaledFood.Add(this);
            this.isPayed = true;
        }
    }
}
