using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model.changeCategoryType
{
    class CategoryType
    {
        public Category.eCategory ChangeEnum(string categoryName)
        {
            switch (categoryName)
            {
                case "샌드위치":
                    return Category.eCategory.Sandwich;
                case "찹샐러드":
                    return Category.eCategory.ChoppedSalads;
                case "추가 토핑":
                    return Category.eCategory.AdditionalToppings;
                case "사이드, 음료":
                    return Category.eCategory.SideAndDrink;
                default:
                    return Category.eCategory.empty;
            }
        }

        public void ChangeString()
        {

        }
    }
}
