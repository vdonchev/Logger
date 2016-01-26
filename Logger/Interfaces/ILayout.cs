namespace LoggerEngine.Interfaces
{
    public interface ILayout
    {
        string Format(IReport reportToFormat);
    }
}