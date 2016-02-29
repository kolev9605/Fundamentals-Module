namespace SOLIDLogger.Layouts
{
    using System;
    using Enums;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        string ILayout.Format(DateTime date, ReportLevel level, string messege)
        {
            return $"{date} - {level} - {messege}";
        }
    }
}