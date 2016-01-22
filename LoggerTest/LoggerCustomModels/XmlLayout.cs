namespace LoggerTest.LoggerCustomModels
{
    using System.Text;
    using LoggerEngine.Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(IMessage msgToFormat)
        {
            var formattedMessage = new StringBuilder();
            formattedMessage.AppendLine("<log>");
            formattedMessage.AppendLine($"\t<date>{msgToFormat.Date}</date>");
            formattedMessage.AppendLine($"\t<level>{msgToFormat.ReportLevel}</level>");
            formattedMessage.AppendLine($"\t<message>{msgToFormat.MessageText}<message>");
            formattedMessage.AppendLine("</log>");

            return formattedMessage.ToString().Trim();
        }
    }
}