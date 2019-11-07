using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubKiLibrary
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int totalCount { get; set; }
        public int totalPrice { get; set; }
        public enum eCategory
        {
            Sandwich,
            ChoppedSalads,
            AdditionalToppings,
            SideAndDrink,
            AllMenu,
            empty
        }
    }
}
