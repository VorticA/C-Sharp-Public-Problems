using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class InvalidBatteriesException : Exception
    {
        public InvalidBatteriesException(string message)
            : base(message)
        {
             
        }
    }
}
