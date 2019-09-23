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
        public SubkiTable()
        {
            FoodList = new List<Food>();
        }
    }
}
