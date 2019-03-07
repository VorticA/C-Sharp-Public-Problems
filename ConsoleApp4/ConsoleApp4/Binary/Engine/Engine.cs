using ConsoleApp4.Binary.Command_Interpreters;
using Loggers.Binary.Command_Interpreters;
using Loggers.Loggers;
using Loggers.Loggers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Binary.Engine
{
    class Engine : IEngine
    {
        public void Run()
        {
            ILogger logger = new Logger();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(logger);
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                string vline = Console.ReadLine();
                commandInterpreter.AddAppender(vline);
            }
            string line = Console.ReadLine();
            while (line.ToLower() != "end")
            {
                commandInterpreter.AddMessage(line);
                line = Console.ReadLine();
            }
            commandInterpreter.LogMessages();
            Console.WriteLine(commandInterpreter.Logger.AppendersToString());
        }
    }
}
