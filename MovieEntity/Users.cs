using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public static class ActiveUSER
    {
        public static int ActiveUserId { get; set; }
        public static int Amount { get; set; }
    }
}
