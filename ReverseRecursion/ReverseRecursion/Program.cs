using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseRecursion
{
    class Program
    {
        static void ReverseArray(ref int[] arr, int start, int end)
        {
            if (start < end)
            {
                int swap = arr[start];
                arr[start] = arr[end];
                arr[end] = swap;
                ReverseArray(ref arr, start + 1, end - 1);
            }
            else return;
        }
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseArray(ref arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadKey();
        }
    }
}
