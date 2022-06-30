using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaProject.DataFiles
{
    public class TemporaryOrderDetails
    {
        public  int ID_OrderDetails { get; set; }
        public int ID_Order { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Price { get; set; }
        public static int Count { get; set; }
        public System.DateTime PositionDateEnd { get; set; }
        public decimal PricePosition { get; set; }
        public decimal PriceDiscount { get; set; }
    }
}
