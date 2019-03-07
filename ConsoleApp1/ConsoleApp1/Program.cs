
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            Console.ReadKey();
        }
        static long Factorial(long n)
        {
            if (n == 1) return 1;
            else return n*Factorial(n - 1);
        }
    }
}
