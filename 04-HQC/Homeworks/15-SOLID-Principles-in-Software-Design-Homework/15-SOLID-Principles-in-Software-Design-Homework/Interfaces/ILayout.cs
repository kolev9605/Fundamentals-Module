namespace SOLIDLogger.Interfaces
{
    using System;
    using Enums;

    public interface ILayout
    {
        string Format(DateTime date, ReportLevel level, string messege);
    }
}