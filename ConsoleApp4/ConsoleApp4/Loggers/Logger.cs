using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.Loggers
{
    using global::Loggers.Appenders.Interfaces;
    using global::Loggers.Enums;
    using Interfaces;
    class Logger : ILogger
    {
        public List<IAppender> Appenders { get; set; }

        public Logger()
        {
            this.Appenders = new List<IAppender>();
        }

        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders.ToList();
        }

        public void AddAppender(IAppender appender)
        {
            Appenders.Add(appender);
        }

        public void Critical(string dateTime, string message)
        {
            Appenders.ForEach(p => p.Append(dateTime, ReportLevel.Critical, message));
        }

        public void Error(string dateTime, string message)
        {
            Appenders.ForEach(p => p.Append(dateTime, ReportLevel.Error, message));
        }

        public void Fatal(string dateTime, string message)
        {
            Appenders.ForEach(p => p.Append(dateTime, ReportLevel.Fatal, message));
        }

        public void Info(string dateTime, string message)
        {
            Appenders.ForEach(p => p.Append(dateTime, ReportLevel.Info, message));
        }

        public void Warning(string dateTime, string message)
        {
            Appenders.ForEach(p => p.Append(dateTime, ReportLevel.Warning, message));
        }

        public string AppendersToString()
        {
            string appendersString = "";
            Appenders.ForEach(p => appendersString += p.ToString());
            return appendersString;
        }
    }
}
