using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Obedinenie_Sechenie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            List<int> arr2 = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            
            Console.WriteLine(string.Join(", ", arr1.Where(p => arr2.Contains(p))));
            Console.WriteLine(string.Join(", ", arr1.Concat(arr2).Distinct().OrderBy(p => p)));
            Console.WriteLine(string.Join(", ", arr1.Concat(arr2.FindAll(a => !arr1.Contains(a)))));
            Console.WriteLine(string.Join(", ", arr1.Concat(arr2.FindAll(a => !arr2.Contains(a)))));
        }
    }
}
