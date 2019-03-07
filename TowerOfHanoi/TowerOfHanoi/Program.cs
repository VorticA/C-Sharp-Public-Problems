using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        static void PrintStack(Stack<int> strt, Stack<int> aux, Stack<int> dest)
        {
            Console.WriteLine("Starting stack:" + string.Join(", ", strt));
            Console.WriteLine("Auxiliary stack:" + string.Join(", ", strt));
            Console.WriteLine(" stack:" + string.Join(", ", strt));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var strt = new Stack<int>(Enumerable.Range(1, 3).Reverse());
            var aux = new Stack<int>();
            var dest = new Stack<int>();
        }
    }
}
