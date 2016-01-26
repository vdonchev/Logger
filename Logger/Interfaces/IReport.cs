namespace LoggerEngine.Interfaces
{
    using System;
    using Enums;

    public interface IReport
    {
        DateTime Date { get; }

        ReportLevel Level { get; }

        string Text { get; }
    }
}