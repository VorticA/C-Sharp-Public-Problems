using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var banWords = Console.ReadLine().Split(' ', ',').ToList();
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord)) text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
