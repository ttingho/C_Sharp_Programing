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
                case "ALL Menu":
                    return Category.eCategory.AllMenu;
                default:
                    return Category.eCategory.empty;
            }
        }

        public string ChangeString(Category.eCategory eCategory)
        {
            switch (eCategory)
            {
                case Category.eCategory.Sandwich:
                    return "샌드위치";
                case Category.eCategory.ChoppedSalads:
                    return "찹샐러드";
                case Category.eCategory.AdditionalToppings:
                    return "추가 토핑";
                case Category.eCategory.SideAndDrink:
                    return "사이드, 음료";
                case Category.eCategory.AllMenu:
                    return "ALL Menu";
                default:
                    return "empty";
            }
        }
    }
}
