﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    class InvalidWebsiteException : Exception
    {
        public InvalidWebsiteException(string message)
            : base(message)
        {

        }
    }
}
