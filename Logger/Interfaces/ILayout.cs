namespace LoggerEngine.Interfaces
{
    public interface ILayout
    {
        string Format(IMessage msgToFormat);
    }
}