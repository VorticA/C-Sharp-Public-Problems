using Loggers.Appenders;
using Loggers.Binary.Command_Interpreters;
using Loggers.Enums;
using Loggers.Layouts;
using Loggers.Loggers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Binary.Command_Interpreters
{
    class CommandInterpreter : ICommandInterpreter
    {
        private ILogger logger;
        private List<string[]> messages;


        public List<string[]> Messages { get => messages; set => messages = value; }
        public ILogger Logger { get => logger; set => logger = value; }

        public CommandInterpreter(ILogger logger)
        {
            this.Logger = logger;
            this.Messages = new List<string[]>();
        }

        public void AddAppender(string args)
        {
            AppenderFactory appenderfactory = new AppenderFactory();
            LayoutFactory layoutfactory = new LayoutFactory();
            string[] arguments = args.Split().ToArray();
            if (arguments.Length == 2)
                logger.AddAppender(appenderfactory.GetAppender(arguments[0], layoutfactory.GetLayout(arguments[1])));
            else
                logger.AddAppender(appenderfactory.GetAppender(arguments[0], layoutfactory.GetLayout(arguments[1]), (ReportLevel)Enum.Parse(typeof(ReportLevel), arguments[2], true)));
        }

        public void AddMessage(string args)
        {
            Messages.Add(args.Split('|'));
        }

        public void LogMessages()
        {
            foreach(string[] message in messages)
            {
                string level = message[0].ToLower();
                if (level == "info") Logger.Info(message[1], message[2]);
                else if (level == "warning") Logger.Warning(message[1], message[2]);
                else if (level == "error") Logger.Error(message[1], message[2]);
                else if (level == "critical") Logger.Critical(message[1], message[2]);
                else if (level == "fatal") Logger.Fatal(message[1], message[2]);
                else throw new ArgumentException("Invalid report level.");
            }
        }
    }
}
