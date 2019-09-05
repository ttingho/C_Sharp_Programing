using SubwayKiosk.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class Menu
    {
        public string KrName { get; set; }

        public string EnName { get; set; }

        public string ImagePath { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public eCategory Category = eCategory.SANDWITCH;
    }
}
