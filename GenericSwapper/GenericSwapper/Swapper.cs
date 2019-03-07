using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapper
{
    public class Swapper
    {
        public static void Swap<T>(List<T> items, int index1, int index2)
        {
            T swap = items[index1];
            items[index1] = items[index2];
            items[index2] = swap;
        }
    }
}
