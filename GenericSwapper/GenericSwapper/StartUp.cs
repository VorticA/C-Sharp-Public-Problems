using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapper
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Box<string>> list = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                list.Add(new Box<string>(Console.ReadLine()));
            }
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            Swapper.Swap<Box<string>>(list, indexes[0], indexes[1]);
            list.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
