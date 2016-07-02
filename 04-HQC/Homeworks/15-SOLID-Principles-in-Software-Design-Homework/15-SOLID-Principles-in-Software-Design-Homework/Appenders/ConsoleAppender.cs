namespace SOLIDLogger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(DateTime date, ReportLevel level, string messege)
        {
            if (this.ReportLevel <= level)
            {
                Console.WriteLine(this.Layout.Format(date, level, messege));
            }
        }
    }
}