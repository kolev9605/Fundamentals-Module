namespace SOLIDLogger.Appenders
{
    using System;
    using System.IO;
    using Enums;
    using Interfaces;

    public class FileAppender : Appender
    {
        private string filePath;

        public FileAppender(ILayout layout, string path)
            : base(layout)
        {
            this.FilePath = path;
        }

        public string FilePath
        {
            get { return this.filePath; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Filepath cannot be null");
                }

                this.filePath = value;
            }
        }

        public override void Append(DateTime date, ReportLevel level, string messege)
        {
            if (this.ReportLevel <= level)
            {
                using (StreamWriter writetext = new StreamWriter(this.FilePath, true))
                {
                    writetext.WriteLine(this.Layout.Format(date, level, messege));
                }
            }
        }
    }
}