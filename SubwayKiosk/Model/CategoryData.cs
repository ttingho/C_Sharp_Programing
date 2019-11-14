using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class CategoryData
    {
        public List<Category> SubkiCategorys { get; set; }
        public void Load()
        {
            SubkiCategorys = new List<Category>()
            {
                new Category() { CategoryName = "ALL Menu", totalCount = 0, totalPrice = 0 },
                new Category() { CategoryName = "샌드위치", totalCount = 0, totalPrice = 0 },
                new Category() { CategoryName = "찹샐러드", totalCount = 0, totalPrice = 0 },
                new Category() { CategoryName = "추가 토핑", totalCount = 0, totalPrice = 0 },
                new Category() { CategoryName = "사이드, 음료", totalCount = 0, totalPrice = 0 },
            };
        }
    }
}
