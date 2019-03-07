using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestLine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> maxLine = new List<int>();
            List<int> currLine = new List<int>
            {
                line[0]
            };

            for (int i=1; i<line.Count; i++)
            {
                if (line[i]==currLine[0])
                {
                    currLine.Add(line[i]);
                    if (currLine.Count > maxLine.Count)
                    {
                        maxLine = new List<int>(currLine);
                    }
                }
                else
                {
                    if (currLine.Count > maxLine.Count)
                    {
                        maxLine = new List<int>(currLine);
                    }
                    currLine.Clear();
                    currLine.Add(line[i]);
                }
            }

            Console.WriteLine($"result\n{string.Join(", ", maxLine)}");
        }
    }
}
