using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyCinemas
{
    public class MidDaySpecialPlugin 
    {
        public bool CalculateSpecial(Booking booking, ref string specialName, ref decimal specialPrice)
        {
            TimeSpan timeOfDay = booking.SessionDate.TimeOfDay;
            // If not mid-day, not applicable.
            // If movie doesn't start between 11am and 1pm
              



            // Calculate the discounted price that we would offer.
            decimal discountedPrice;




            // If this discount is applicable, set specialName and specialPrice to our name and price.
           
            
        }
    }
}
