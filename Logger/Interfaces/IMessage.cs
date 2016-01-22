namespace LoggerEngine.Interfaces
{
    using System;
    using Enums;

    public interface IMessage
    {
        DateTime Date { get; }

        ReportLevel ReportLevel { get; }

        string MessageText { get; }
    }
}