namespace LoggerEngine.Interfaces
{
    using Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void Append(IReport report);
    }
}