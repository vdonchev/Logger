namespace LoggerEngine.Models.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class AppenderBase : IAppender
    {
        private ILayout layout;

        protected AppenderBase(ILayout layout)
        {
            this.Layout = layout;
        }
        
        public ReportLevel ReportLevel { get; set; }

        protected ILayout Layout
        {
            get
            {
                return this.layout;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Layout cannot be null");
                }

                this.layout = value;
            }
        }

        public abstract void Append(IReport message);
    }
}