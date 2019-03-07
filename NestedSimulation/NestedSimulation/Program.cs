    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedSimulation
{
    class Program
    {
        static void Simulate(int[] vec, int ind)
        {
            int n = vec.Length;
            if (ind == n) Console.WriteLine(string.Join(" ", vec));
            else
            {
                for (int i=1; i<=n; i++)
                {
                    vec[ind] = i;
                    Simulate(vec, ind + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            Simulate(vec, 0);
            Console.ReadKey();
        }
    }
}
