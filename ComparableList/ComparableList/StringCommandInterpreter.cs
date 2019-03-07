using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    class StringCommandInterpreter : IBoxCommandInterpreter<string>
    {
        private IBox<string> box;
        public StringCommandInterpreter(IBox<string> box)
        {
            this.box = box;
        }

        public void GetCommand(string line)
        {
            string[] command = line.Split().ToArray();
            var key = command[0].ToLower();
            if (key == "add") box.Add(command[1]);
            else if (key == "remove") box.Remove(int.Parse(command[1]));
            else if (key == "contains") Console.WriteLine(box.Contains(command[1]));
            else if (key == "swap") box.Swap(int.Parse(command[1]), int.Parse(command[2]));
            else if (key == "greater") Console.WriteLine(box.CountGreaterThan(command[1]));
            else if (key == "max") Console.WriteLine(box.Max());
            else if (key == "min") Console.WriteLine(box.Min());
            else if (key == "sort") box.Sort();
            else if (key == "print") Console.WriteLine(String.Join("\n", box));
        }
    }
}
