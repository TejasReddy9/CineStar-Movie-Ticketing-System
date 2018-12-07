using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class BookingClass
    {


        public int ScreenId { get; set; }
        public string ShowSlot { get; set; }
        public int GoldSeatsLeft { get; set; }
        public int SilverSeatsLeft { get; set; }
        public int GoldPrice { get; set; }
        public int SilverPrice { get; set; }

    }
}
