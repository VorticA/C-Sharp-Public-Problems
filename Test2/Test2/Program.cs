using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            var b = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * a;
            if (D < 0) Console.WriteLine("No solutions.");
            else if (D == 0) Console.WriteLine("One solution.");
            else Console.WriteLine("Two solutions.");
            Console.ReadKey();
        }
    }
}
