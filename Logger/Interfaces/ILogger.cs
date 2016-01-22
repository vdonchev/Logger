namespace LoggerEngine.Interfaces
{
    public interface ILogger
    {
        void Info(string massage);

        void Warn(string massage);

        void Error(string massage);

        void Critical(string massage);

        void Fatal(string massage);
    }
}