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
        public bool isLoaded = false;
        public List<Category> SubkiCategorys { get; set; }
        public void Load()
        {
            if (isLoaded)
            {
                return;
            }

            SubkiCategorys = new List<Category>()
            {
                new Category() { CategoryName = "샌드위치" },
                new Category() { CategoryName = "찹샐러드" },
                new Category() { CategoryName = "추가 토핑" },
                new Category() { CategoryName = "사이드, 음료" },
            };

            isLoaded = true;
        }
    }
}
