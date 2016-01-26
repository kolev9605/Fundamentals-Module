namespace SOLIDLogger
{
    using System;
    using Enums;
    using Interfaces;

    public class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender { get; set; }

        public void Info(string msg)
        {
            this.Log(ReportLevel.Info, msg);
        }

        public void Warn(string msg)
        {
            this.Log(ReportLevel.Warn, msg);
        }

        public void Error(string msg)
        {
            this.Log(ReportLevel.Error, msg);
        }

        public void Critical(string msg)
        {
            this.Log(ReportLevel.Critical, msg);
        }

        public void Fatal(string msg)
        {
            this.Log(ReportLevel.Fatal, msg);
        }

        private void Log(ReportLevel level, string msg)
        {
            DateTime date = DateTime.Now;
            this.Appender.Append(date, level, msg);
        }
    }
}