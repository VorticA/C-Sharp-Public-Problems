using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            var first = nums.Take(k).Reverse();
            var middle = nums.Skip(k).Take(2 * k).ToArray();
            var last = nums.Skip(3 * k).Take(k).Reverse().ToArray();
            var upper = first.Concat(last).ToArray();
            middle = middle.Select((x, i) => x + upper[i]).ToArray();
            Console.WriteLine(string.Join(" ", middle));
            Console.ReadKey();
        }
    }
}
