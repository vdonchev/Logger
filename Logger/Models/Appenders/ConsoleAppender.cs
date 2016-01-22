﻿namespace LoggerEngine.Models.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : AppenderBase
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(IMessage message)
        {
            if (message.ReportLevel >= this.ReportLevel)
            {
                var formattedMsg = this.Layout.Format(message);

                Console.WriteLine(formattedMsg);
            }
        }
    }
}