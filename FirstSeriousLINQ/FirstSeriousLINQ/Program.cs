﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSeriousLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .ToLower()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '/', '\\', '!', '?', ' ')
                .Distinct().Where(p => p.Length < 5 && p != "")
                .OrderBy(p => p)
                .ToList()));
            Console.ReadKey();
        }
    }
}
