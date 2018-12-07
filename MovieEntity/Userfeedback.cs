using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Userfeedback
    {
        public int feedbackId { get; set; }
        public string feedback { get; set; }
        public int count { get; set; }
    }


    public class AdminReport
    {
        
        public string feedback { get; set; }
        public int count { get; set; }
    }

}
