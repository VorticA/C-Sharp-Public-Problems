using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<RationalNumber> Numbers = new List<RationalNumber>();
            for (int i = 0; i < line.Count; i += 2)
            {
                Numbers.Add(new RationalNumber(line[i], line[i + 1]));
            }
            Numbers.ForEach(p => p.MakeUndivisible());
            Console.WriteLine(string.Join("; ", Numbers));
        }
    }
}
