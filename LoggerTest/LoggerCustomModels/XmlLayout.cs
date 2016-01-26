namespace LoggerTest.LoggerCustomModels
{
    using System.Text;
    using LoggerEngine.Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(IReport msgToFormat)
        {
            var formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("<log>");
            formattedMessage.AppendLine($"\t<date>{msgToFormat.Date}</date>");
            formattedMessage.AppendLine($"\t<level>{msgToFormat.Level}</level>");
            formattedMessage.AppendLine($"\t<message>{msgToFormat.Text}<message>");
            formattedMessage.AppendLine("</log>");

            return formattedMessage.ToString().Trim();
        }
    }
}