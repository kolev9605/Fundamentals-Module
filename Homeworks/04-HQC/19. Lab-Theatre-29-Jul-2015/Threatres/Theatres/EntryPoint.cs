namespace Theatres
{
    using Core;
    using Interfaces;
    using IO;

    public class EntryPoint
    {
        public static void Main()
        {
            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();
            IPerformanceDatabase database = new PerformanceDatabase();
            IEngine engine = new Engine(consoleReader, consoleWriter, database);

            engine.Run();
        }
    }
}