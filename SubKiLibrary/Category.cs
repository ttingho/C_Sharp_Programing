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
        public enum eCategory
        {
            Sandwich,
            ChoppedSalads,
            AdditionalToppings,
            SideAndDrink,
            empty
        }
    }
}
