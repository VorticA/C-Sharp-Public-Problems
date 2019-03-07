using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    class Engine<T> : IEngine
    {
        IBoxCommandInterpreter<T> commandInterpreter;

        public Engine(IBoxCommandInterpreter<T> commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string line = Console.ReadLine();
            while (line.ToLower() != "end")
            {
                commandInterpreter.GetCommand(line);
                line = Console.ReadLine();
            }
        }
    }
}
