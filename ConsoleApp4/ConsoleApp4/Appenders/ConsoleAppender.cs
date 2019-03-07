using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Appenders
{
    using global::Loggers.Enums;
    using global::Loggers.Layouts.Interfaces;
    using Interfaces;
    class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ConsoleAppender(ILayout layout, ReportLevel threshold)
           : this(layout)
        {
            base.Threshold = threshold;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.Threshold)
            {
                Console.Write(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                base.Messages++;
            }
        }

        public override string ToString()
        {
            return "Appender type: ConsoleAppender, " + "Layout type: " + Layout.GetType() + ", Report Level: " + base.Threshold + ", Messages appended: " + base.Messages + "\n";
        }
    }
}
