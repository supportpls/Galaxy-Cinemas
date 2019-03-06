using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Business_Objects
{
    public class Booking
    {
        public int BookingNumber { set; get; }
        public int SessionID { set; get; }
        public int Quantity { set; get; }
        public DateTime SessionDate { set; get; }
        public String Special { set; get; }
        public decimal Discount { set; get; }
        public decimal OriginalPrice { set; get; }
        public decimal FinalPrice { set; get; }

        public Booking()
        {

        }

    }
}
