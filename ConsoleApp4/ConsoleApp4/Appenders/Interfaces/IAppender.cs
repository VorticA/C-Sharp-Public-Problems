using Loggers.Enums;
using Loggers.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Appenders.Interfaces
{
    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);
        ReportLevel Threshold { get; set; }
        ILayout Layout { get; set; }
        int Messages { get; set; }
    }
}
