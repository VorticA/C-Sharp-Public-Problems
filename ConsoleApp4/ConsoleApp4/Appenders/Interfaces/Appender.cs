using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggers.Enums;
using Loggers.Layouts.Interfaces;

namespace Loggers.Appenders.Interfaces
{
    public abstract class Appender : IAppender
    {
        private ReportLevel threshold;
        private ILayout layout;
        private int messages;

        public ReportLevel Threshold { get => threshold; set => threshold = value; }

        public ILayout Layout { get => layout; set => layout = value; }

        public int Messages { get => messages; set => messages = value; }


        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
        public abstract override string ToString();
    }
}
