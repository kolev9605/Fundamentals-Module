namespace SOLIDLogger
{
    using System;
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
            IAppender fileAppender = new FileAppender(layout, "file.txt");
            IAppender consoleAppender = new ConsoleAppender(layout);
            Logger logger = new Logger(consoleAppender);

            //shows every report level above ReportLevel.Warn
            consoleAppender.ReportLevel = ReportLevel.Fatal;

            logger.Critical("Critical Sample Report");
            logger.Fatal("Fatal Sample Report");
            logger.Info("Info Sample Report");
        }
    }
}