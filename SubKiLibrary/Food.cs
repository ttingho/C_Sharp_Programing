

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SubKiLibrary.Category;

namespace SubKiLibrary
{
    public class Food
    {
        public string KrName { get; set; }
        public string EnName { get; set; }
        public int Price { get; set; }
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                if (count < 0)
                {
                    count = 0;
                }
            }
        }
        public string ImagePath { get; set; }
        public eCategory Category { get; set; }

        public Food Clone()
        {
            Food retval = new Food();

            retval.Count = count;
            retval.Category = Category;
            retval.EnName = EnName;
            retval.ImagePath = ImagePath;
            retval.KrName = KrName;
            retval.Price = Price;
            retval.Category = Category;
            return retval;
        }
    }
}
