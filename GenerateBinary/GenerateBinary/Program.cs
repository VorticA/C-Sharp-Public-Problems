using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateBinary
{
    class Program
    {
        static void GenBin(int[] arr, int index)
        {
            if (index==arr.Length)
                Console.WriteLine(string.Join("", arr));
            else
            {
                for (int i=0; i<=1; i++)
                {
                    arr[index] = i;
                    GenBin(arr, index + 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            GenBin(arr, 0);
            Console.ReadKey();
        }
    }
}
