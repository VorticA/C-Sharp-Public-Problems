using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCombination
{
    class Program
    {
        static void Combine(int[] set, int[] vec, int ind, int border)
        {
            if (ind==vec.Length)
            {
                Console.WriteLine(string.Join(" ", vec));
            }
            else
            {
                for (int i = border; i<set.Length; i++)
                {
                    vec[ind] = set[i];
                    Combine(set, vec, ind + 1, i + 1);
                }
            }
        }
        
        static void Main(string[] args)
        {
            var set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] vec = new int[2];
            Combine(set, vec, 0, 0);
            Console.ReadKey();
        }
    }
}
