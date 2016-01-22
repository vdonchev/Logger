namespace LoggerEngine.Core.Factories
{
    using System;
    using Enums;
    using Interfaces;
    using Models;

    public static class MessageFactory
    {
        public static IMessage Create(DateTime date, ReportLevel reportLevel, string messageText)
        {
            IMessage message = new Message(date, reportLevel, messageText);

            return message;
        }
    }
}