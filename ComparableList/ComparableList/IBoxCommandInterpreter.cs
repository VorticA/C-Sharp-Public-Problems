using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    interface IBoxCommandInterpreter<T>
    {
        void GetCommand(string command);
    }
}
