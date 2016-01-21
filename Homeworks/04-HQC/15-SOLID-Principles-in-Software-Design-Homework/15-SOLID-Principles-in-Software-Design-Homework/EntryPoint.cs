namespace SOLIDLogger
{
    using Appenders;
    using Enums;
    using Interfaces;
    using Layouts;

    public class EntryPoint
    {
        static void Main()
        {
            //Init dependencies
            ILayout layout = new XmlLayout();
            IAppender appender = new ConsoleAppender(layout);
            Logger logger = new Logger(appender);

            //shows every report level above ReportLevel.Warn
            appender.ReportLevel = ReportLevel.Warn;

            logger.Critical("Critical Sample Report");
            logger.Fatal("Fatal Sample Report");
            logger.Info("Info Sample Report");
        }
    }
}