namespace SOLIDLogger.Interfaces
{
    using System;
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(DateTime date, ReportLevel level, string messege);
    }
}