﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubKiLibrary;

namespace SubwayKiosk.Model
{
    public class FoodData
    {
        public bool isLoaded = false;
        public List<Food> lstMenu = null;

        public void Load()
        {
            if(isLoaded)
            {
                return;
            }

            if (lstMenu != null)
            {
                return;
            }
                
            lstMenu = new List<Food>()
            {
                new Food(){ KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg"},
                new Food(){ KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg"},
                new Food(){ KrName = "로티세리 바비큐 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg"},
                new Food(){ KrName = "풀드포크", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_004.jpg"},
                new Food(){ KrName = "에그마요", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_005.jpg"},
                new Food(){ KrName = "미트볼", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_006.jpg"},
                new Food(){ KrName = "비엘티", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_007.jpg"},
                new Food(){ KrName = "햄", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_008.jpg"},
                new Food(){ KrName = "참치", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_009.jpg"},
                new Food(){ KrName = "로스트 치킨", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_010.jpg"},
            };
        }
    }
}