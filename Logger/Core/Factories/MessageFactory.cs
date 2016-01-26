namespace LoggerEngine.Core.Factories
{
    using System;
    using Enums;
    using Interfaces;
    using Models;

    public static class MessageFactory
    {
        public static IReport Create(DateTime date, ReportLevel reportLevel, string messageText)
        {
            IReport message = new Report(date, reportLevel, messageText);

            return message;
        }
    }
}