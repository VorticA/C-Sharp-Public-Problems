using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private static List<int> currSol = new List<int>();
        private static List<int> bestSolution = new List<int>();
        private static void GetNumber(int startNumber, int searchedNumber)
        {
            if (startNumber > searchedNumber)
            {
                return;
            }
            if (startNumber == searchedNumber)
            {
                if (currSol.Count < bestSolution.Count || bestSolution.Count==0) bestSolution = new List<int>(currSol);
            }
            currSol.Add(startNumber + 1 );
            GetNumber(startNumber + 1, searchedNumber);
            currSol.RemoveAt(currSol.Count - 1);

            currSol.Add(startNumber + 2);
            GetNumber(startNumber + 2, searchedNumber);
            currSol.RemoveAt(currSol.Count - 1);

            currSol.Add(startNumber * 2);
            GetNumber(startNumber * 2, searchedNumber);
            currSol.RemoveAt(currSol.Count - 1);
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();
            currSol.Add(input[0]);
            GetNumber(input[0], input[1]);
            if (bestSolution.Count==0)
            {
                Console.WriteLine("No solutions");
            }
            else
                Console.WriteLine(string.Join(" -> ", bestSolution));
        }
    }
}
