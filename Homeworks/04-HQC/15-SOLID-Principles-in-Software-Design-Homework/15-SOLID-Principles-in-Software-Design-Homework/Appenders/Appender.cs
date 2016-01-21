namespace SOLIDLogger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; }

        public abstract void Append(DateTime date, ReportLevel level, string messege);
    }
}