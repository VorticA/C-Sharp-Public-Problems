using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidSongException : Exception
    {
        public InvalidSongException()
            : base()
        {

        }
        public InvalidSongException(string message)
            : base(message)
        {
        
        }
    }
}
