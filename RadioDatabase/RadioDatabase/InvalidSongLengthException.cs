using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException()
            : base()
        {

        }
        public InvalidSongLengthException(string message)
            : base(message)
        {

        }
    }
}
