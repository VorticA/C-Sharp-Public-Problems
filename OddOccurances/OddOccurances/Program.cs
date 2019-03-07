using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToList();
            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dict.ContainsKey(word)) dict[word]++;
                else dict.Add(word, 1);
            }
            //int br = 0;
            ////foreach (var Pair in dict)
            ////{

            ////    if (Pair.Value % 2 == 1)
            ////    {
            ////        if (br != 0) Console.Write(", ");
            ////        br++;
            ////        Console.Write(Pair.Key);
            ////    }
            ////}
            Console.WriteLine(string.Join(", ", dict.Keys.Where(p => dict[p]%2==1)));
            Console.ReadKey();
        }
    }
}
