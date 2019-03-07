using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeFigureRecursion
{
    class Program
    {
        static void PrintFig(int n)
        {
            if (n == 0) return;
            Console.WriteLine(new string('*', n));
            PrintFig(n - 1);
            Console.WriteLine(new string('#', n));
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintFig(n);
            Console.ReadKey();
        }
    }
}
