using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string edited = input.TrimEnd("0123456789".ToCharArray());
            List<char> result = new List<char>();
            for (int i = 0; i < edited.Length; i++)
            {
                if (char.IsLetter(edited[i]))
                {
                    result.Add(edited[i]);
                }
                else
                {
                    while (i < edited.Length && char.IsDigit(edited[i]))
                    {
                        i++;
                    }
                    result.Add(edited[i]);
                    
                }
            }
            result.AddRange(input.Skip(edited.Length));
            Console.WriteLine(string.Join("", result));
        }
    }
}
