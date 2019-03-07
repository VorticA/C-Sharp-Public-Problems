using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    public class Program
    {
        public static int Steps = 0;
        public static Stack<int> Source;
        public static Stack<int> Auxiliary = new Stack<int>();
        public static Stack<int> Destination = new Stack<int>();
        public static void Move(int disk, ref Stack<int> src, ref Stack<int> dest, ref Stack<int> aux)
        {
            if (disk==1)
            {
                Steps++;
                dest.Push(src.Pop());
                Console.WriteLine("Step #{0}: Moved disk {1}", Steps, disk);
                PrintPegs();
            }
            else
            {
                Move(disk - 1, ref src, ref aux, ref dest);
                dest.Push(src.Pop());
                Steps++;
                Console.WriteLine("Step #{0}: Moved disk {1}", Steps, disk);
                PrintPegs();
                Move(disk - 1, ref aux, ref dest, ref src);
            }
        }

        public static void PrintPegs()
        {
            Console.WriteLine("Source: " + string.Join(", ", Source.Reverse()));
            Console.WriteLine("Destination: " + string.Join(", ", Destination.Reverse()));
            Console.WriteLine("Spare: " + string.Join(", ", Auxiliary.Reverse()));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Engine.Run();
        }
    }
}
