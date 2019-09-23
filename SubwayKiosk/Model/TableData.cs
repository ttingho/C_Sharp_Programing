using SubKiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayKiosk.Model
{
    public class TableData
    {
        public bool isLoaded = false;
        public List<SubkiTable> SubkiTables { get; set; }
        public void Load()
        {
            if (isLoaded)
            {
                return;
            }

            SubkiTables = new List<SubkiTable>()
            {
                new SubkiTable() { Idx = 1, TotalPrice = 12000, Payment = Payment.ePayment.Cash  },
                new SubkiTable() { Idx = 2, TotalPrice = 20000, Payment = Payment.ePayment.Card  },
                new SubkiTable() { Idx = 3, TotalPrice = 15000, Payment = Payment.ePayment.Card  },
                new SubkiTable() { Idx = 4, TotalPrice = 10000, Payment = Payment.ePayment.Cash  },
                new SubkiTable() { Idx = 5, TotalPrice = 8000, Payment = Payment.ePayment.Cash  },
                new SubkiTable() { Idx = 6, TotalPrice = 4500, Payment = Payment.ePayment.Card  },
            };

            isLoaded = true;
        }
    }
}
