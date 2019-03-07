using Loggers.Enums;
using Loggers.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Appenders.Interfaces
{
    interface IAppenderFactory
    {
        IAppender GetAppender(string name, ILayout layout);
        IAppender GetAppender(string name, ILayout layout, ReportLevel threshold);
    }
}
