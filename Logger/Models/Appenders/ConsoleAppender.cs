namespace LoggerEngine.Models.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : AppenderBase
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(IReport report)
        {
            if (report.Level >= this.ReportLevel)
            {
                var formattedMsg = this.Layout.Format(report);

                Console.WriteLine(formattedMsg);
            }
        }
    }
}