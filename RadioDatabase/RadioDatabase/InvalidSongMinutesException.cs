using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException()
            : base()
        {

        }
        public InvalidSongMinutesException(string messages)
            : base(messages)
        {

        }
    }
}
