using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class MenuData
    {
        public bool isLoaded = false;
        public List<Menu> lstMenu = null;

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
                
            lstMenu = new List<Menu>()
            {
                new Menu(){ KrName = "쉬림프", EnName = "Shrimp", ImagePath = @"\Assets\SUBWAY_Sand\subway_001.jpg"},
                new Menu(){ KrName = "쉬림프 아보카도", EnName = "Shrimp Avocado", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg"},
            };
        }
    }
}
