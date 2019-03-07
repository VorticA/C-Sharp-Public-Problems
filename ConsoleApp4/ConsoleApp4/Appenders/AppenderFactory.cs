using Loggers.Appenders.Interfaces;
using Loggers.Enums;
using Loggers.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Appenders
{
    class AppenderFactory : IAppenderFactory
    {
        public IAppender GetAppender(string name, ILayout layout)
        {
            if (name.ToLower() == "consoleappender") return new ConsoleAppender(layout);
            else if (name.ToLower() == "fileappender") return new FileAppender(layout);
            else throw new ArgumentException("Invalid appender name.");
        }

        public IAppender GetAppender(string name, ILayout layout, ReportLevel threshold)
        {
            if (name.ToLower() == "consoleappender") return new ConsoleAppender(layout, threshold);
            else if (name.ToLower() == "fileappender") return new FileAppender(layout, threshold);
            else throw new ArgumentException("Invalid appender name.");
        }
    }
}
