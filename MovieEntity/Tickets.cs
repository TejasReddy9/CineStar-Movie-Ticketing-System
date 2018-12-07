using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Tickets
    {
        public int TicketID { get; set; }
        public string TransactionData { get; set; }
        public int ViewerID { get; set; }
        public int ShowID { get; set; }
        public string TypeOfSeat { get; set; }
        public int NoOfTickets { get; set; }
    }
}
