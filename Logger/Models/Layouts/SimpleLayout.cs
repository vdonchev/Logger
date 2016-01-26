namespace LoggerEngine.Models.Layouts
{
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(IReport reportToFormat)
        {
            var formattedMessage = $"{reportToFormat.Date} - {reportToFormat.Level} - {reportToFormat.Text}";

            return formattedMessage;
        }
    }
}