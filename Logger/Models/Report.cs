namespace LoggerEngine.Models
{
    using System;
    using Enums;
    using Interfaces;

    public class Report : IReport
    {
        private string text;

        public Report(DateTime date, ReportLevel level, string text)
        {
            this.Date = date;
            this.Level = level;
            this.Text = text;
        }

        public DateTime Date { get; private set; }

        public ReportLevel Level { get; private set; }

        public string Text
        {
            get
            {
                return this.text;
            }

            private set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Report cannot be empty or null.");
                }

                this.text = value;
            }
        }
    }
}