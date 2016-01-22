namespace LoggerEngine.Models
{
    using System;
    using Enums;
    using Interfaces;

    public class Message : IMessage
    {
        private string messageText;

        public Message(DateTime date, ReportLevel reportLevel, string messageText)
        {
            this.Date = date;
            this.ReportLevel = reportLevel;
            this.MessageText = messageText;
        }

        public DateTime Date { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public string MessageText
        {
            get
            {
                return this.messageText;
            }

            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Message cannot be empty or null.");
                }

                this.messageText = value;
            }
        }
    }
}