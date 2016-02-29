namespace Theatres.Core
{
    using System;
    using System.Linq;
    using Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IPerformanceDatabase database;

        public Engine(IReader reader, IWriter writer, IPerformanceDatabase database)
        {
            this.reader = reader;
            this.writer = writer;
            this.database = database;
        }

        public void Run()
        {
            while (true)
            {
                string inputString = this.reader.ReadLine();

                if (inputString == null || inputString == "over")
                {
                    return;
                }

                if (inputString != string.Empty)
                {
                    string[] inputParams = inputString.Split('(');
                    string commandName = inputParams[0];
                    string output;
                    try
                    {
                        string[] commandParams = inputString
                            .Split(new[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries)
                            .Skip(1)
                            .Select(p => p.Trim())
                            .ToArray();

                        switch (commandName)
                        {
                            case "AddTheatre":
                                output = Command.ExecuteAddTheatreCommand(commandParams, this.database);
                                break;
                            case "PrintAllTheatres":
                                output = Command.ExecutePrintAllTheatresCommand(this.database);
                                break;
                            case "AddPerformance":
                                output = Command.ExecuteAddPerformanceCommand(commandParams, this.database);
                                break;
                            case "PrintAllPerformances":
                                output = Command.ExecutePrintAllPerformancesCommand(this.database);
                                break;
                            case "PrintPerformances":
                                output = Command.ExecutePrintPerformanceCommand(commandParams, this.database);
                                break;
                            default:
                                output = "Invalid command!";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        output = "Error: " + ex.Message;
                    }

                    this.writer.WriteLine(output);
                }
            }
        }
    }
}