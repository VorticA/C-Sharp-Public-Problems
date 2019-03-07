using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hideout
{
    class Program
    {
        static void SearchHideout(string map, char searchFor, int index)
        {
            int br = 0;
            for (int i = index; i < map.Length; i++)
            {
                br++;
                if (map[i] != searchFor)
                {
                    break;
                }
            }
            Console.WriteLine("Hideout found at index {0} and it is with size {1}!", index, br);
        }
        static void Main(string[] args)
        {
            var map = Console.ReadLine();
            while(true)
            {
                var line = Console.ReadLine().Split().ToList();
                var hideout = new string(line[0][0], int.Parse(line[1]));
                int index = map.IndexOf(hideout);
                if (index != -1) { SearchHideout(map, line[0][0], index); break; }
            }
            Console.ReadKey();
        }
    }
}
