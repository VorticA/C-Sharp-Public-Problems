using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException()
            : base()
        {

        }
        public InvalidSongSecondsException(string messages)
            : base(messages)
        {

        }
    }
}
