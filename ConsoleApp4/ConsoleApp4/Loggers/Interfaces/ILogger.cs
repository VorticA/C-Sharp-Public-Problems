using Loggers.Appenders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Loggers.Interfaces
{
    interface ILogger
    {
        List<IAppender> Appenders { get; set; }

        void AddAppender(IAppender appender);

        void Info(string dateTime, string message);
        void Warning(string dateTime, string message);
        void Error(string dateTime, string message);
        void Critical(string dateTime, string message);
        void Fatal(string dateTime, string message);

        string AppendersToString();
    }
}
