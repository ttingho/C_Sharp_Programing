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
                new Menu(){ Name = "쉬림프버거", ImagePath = @"\Assets\SUBWAY_Sand\subway_002.jpg"},
                new Menu(){ Name = "시끄러버거", ImagePath = @"\Assets\SUBWAY_Sand\subway_003.jpg"},
            };

        }


    }
}
