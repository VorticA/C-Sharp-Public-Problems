using Loggers.Loggers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Binary.Command_Interpreters
{
    interface ICommandInterpreter
    {
        ILogger Logger { get; set; }
        List<string[]> Messages { get; set; }

        void AddAppender(string args);
        void AddMessage(string args);

        void LogMessages();
    }
}
