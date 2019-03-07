using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> reverse = new Stack<int>(stack.ToArray().Reverse());
            Console.WriteLine(string.Join(", ", reverse.ToArray()));
        }
    }
}
