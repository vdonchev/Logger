namespace LoggerEngine.Models.Layouts
{
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(IMessage msgToFormat)
        {
            var formattedMessage = $"{msgToFormat.Date} - {msgToFormat.ReportLevel} - {msgToFormat.MessageText}";

            return formattedMessage;
        }
    }
}