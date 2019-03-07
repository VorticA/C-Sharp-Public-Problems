using Loggers.Appenders.Interfaces;
using Loggers.Enums;
using Loggers.FIleClasses;
using Loggers.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Appenders
{
    class FileAppender : Appender
    {
        private ILogFile logfile;
        private string directory;

        internal ILogFile Logfile { get => logfile; set => logfile = value; }
        public string Directory { get => directory; set => directory = value; }

        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
            this.Logfile = new LogFile();
            this.Directory = "C:\\Users\\viki8\\source\\repos\\ConsoleApp4\\ConsoleApp4\\FileClasses\\Logs\\log.txt";
        }

        public FileAppender(ILayout layout, ReportLevel threshold)
            : this(layout)
        {
            base.Threshold = threshold;
        }


        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel>= base.Threshold)
            {
                this.Logfile.Write(directory, string.Format(base.Layout.Format, dateTime, reportLevel, message));
                base.Messages++;
            }
        }

        public override string ToString()
        {
            return "Appender type: FileAppender, " + "Layout type: " + Layout.GetType() + ", Report Level: " + base.Threshold + ", Messages appended: " + base.Messages + ", File size: " + this.Logfile.Size + "\n";
        }
    }
}
