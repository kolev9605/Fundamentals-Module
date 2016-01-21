namespace SOLIDLogger.Layouts
{
    using System;
    using System.Text;
    using Enums;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(DateTime date, ReportLevel level, string messege)
        {
            var builder = new StringBuilder();

            builder.AppendLine("<log>");

            builder.Append("\t<date>");
            builder.Append(date);
            builder.AppendLine("</date>");

            builder.Append("\t<level>");
            builder.Append(level);
            builder.AppendLine("</level>");

            builder.Append("\t<messege>");
            builder.Append(messege);
            builder.AppendLine("</messege>");

            builder.AppendLine("</log>");

            return builder.ToString();
        }
    }
}