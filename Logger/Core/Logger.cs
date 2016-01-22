namespace LoggerEngine.Core
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Factories;
    using Interfaces;

    public class Logger : ILogger
    {
        private readonly IList<IAppender> appenders;
        
        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>(appenders);
        }

        public void Info(string message)
        {
            this.WriteLog(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.WriteLog(message, ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.WriteLog(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.WriteLog(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.WriteLog(message, ReportLevel.Fatal);
        }

        private void WriteLog(string messageText, ReportLevel reportLevel)
        {
            var message = MessageFactory.Create(DateTime.Now, reportLevel, messageText);

            foreach (var appender in this.appenders)
            {
                appender.Append(message);
            }
        }
    }
}