using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    public static class Engine
    {

        public static void Run()
        {
            var n = int.Parse(Console.ReadLine());
            Program.Source = new Stack<int>(Enumerable.Range(1, n).Reverse());
            Program.PrintPegs();
            Program.Move(n, ref Program.Source, ref Program.Destination, ref Program.Auxiliary);
            Console.ReadKey();
        }
    }
}
