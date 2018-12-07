using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieException
{
    public class MTSException : ApplicationException
    {
        public MTSException() : base() { }

        public MTSException(string message) : base(message) { }

        public MTSException(string message, Exception innerException) : base(message, innerException) { }

    }
}
