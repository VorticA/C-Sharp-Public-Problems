using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var Phonebook = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine().Split().ToList();
                if (line[0] == "A") AddPerson(ref Phonebook, line[1], line[2]);
                else if (line[0] == "S") DisplayContact(Phonebook, line[1]);
                else if (line[0].ToUpper() == "END") break;
            }
            Console.ReadKey();
        }
        static void AddPerson(ref Dictionary<string, string> dict, string name, string number)
        {
            if (dict.ContainsKey(name)) dict[name] = number;
            else dict.Add(name, number);
        }
        static void DisplayContact(Dictionary<string, string> dict, string name)
        {
            if (!dict.ContainsKey(name)) Console.WriteLine("Contact {0} does not exist.", name);
            else Console.WriteLine("{0} -> {1}", name, dict[name]);
        }
    }
}
