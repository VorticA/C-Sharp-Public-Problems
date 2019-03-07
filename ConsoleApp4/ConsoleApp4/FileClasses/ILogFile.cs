using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.FIleClasses
{
    interface ILogFile
    {
        void Write(string directory, string message);
        int Size { get; }
    }
}
