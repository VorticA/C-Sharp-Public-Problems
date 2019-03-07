using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
            : base()
        {

        }
        public InvalidArtistNameException(string message)
            : base(message)
        {

        }
    }
}
