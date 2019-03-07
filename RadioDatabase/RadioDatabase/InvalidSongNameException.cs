using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            : base()
        {

        }
        public InvalidSongNameException(string message)
            : base(message)
        {

        }
    }
}
