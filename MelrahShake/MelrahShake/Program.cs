using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void ShakeIt(string text, string pattern)
        {
            int Times = HowManyTimes(text, pattern);
            if (Times>1)
            {
                Console.WriteLine("Shaked it.");
                text = text.Remove(text.IndexOf(pattern), pattern.Length);
                text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);
                ShakeIt(text, pattern);
            }
            else
            {
                Console.WriteLine("No Shake.");
                Console.WriteLine(text);
            }
        }
        static int HowManyTimes(string text, string pattern)
        {
            int br = 0;
            int ind = text.IndexOf(pattern);
            while (ind!=-1)
            {
                br++;
                ind = text.IndexOf(pattern, ind + 1);
            }
            return br;
        }
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            ShakeIt(line1, line2);
            Console.ReadKey();
        }
    }
}
