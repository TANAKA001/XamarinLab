using App_Cels.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Cels.Controller
{
    public class ShoresController
    {
        public static List<Shore> ListShore()
        {
            List<Shore> _shores = new List<Shore> {
                new Shore{Name = "Laundry", Category = "HouseHold"},
                new Shore{Name = "Dishes", Category = "Kitchen"},
                new Shore{Name = "VacumClean", Category = "HouseHold"},
                new Shore{Name = "Cook", Category = "Kitchen"},
            };

            return _shores;
        }
    }
}
