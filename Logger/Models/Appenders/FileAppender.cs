namespace LoggerEngine.Models.Appenders
{
    using System;
    using System.IO;
    using Interfaces;

    public class FileAppender : AppenderBase
    {
        private string file;

        public FileAppender(ILayout layout) 
            : base(layout)
        {
        }

        public string File
        {
            get
            {
                return this.file;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("File path cannot be null or empty");
                }

                this.file = value;
            }
        }

        public override void Append(IMessage message)
        {
            if (message.ReportLevel >= this.ReportLevel)
            {
                using (var writer = new StreamWriter(this.File, true))
                {
                    var formattedMessage = this.Layout.Format(message);

                    writer.WriteLine(formattedMessage);
                }
            }
        }
    }
}