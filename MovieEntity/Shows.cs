using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Shows
    {
        public int ShowID { get; set; }
        public int ScreenID { get; set; }
        public int MovieID { get; set; }
        public string ShowSlot { get; set; }
        public DateTime ShowDate { get; set; }
        public int GoldPrice { get; set; }
        public int SilverPrice { get; set; }

    }
}
