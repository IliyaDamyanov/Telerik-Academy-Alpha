using System;

using OlympicGames.Core.Contracts;
using OlympicGames.Core.Factories;
using OlympicGames.Core.Providers;

namespace OlympicGames.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandParser commandParser;
        private readonly ICommandProcessor commandProcessor;
        private readonly IOlympicsFactory factory;
        private readonly IOlympicCommittee commitee;

        private const string Delimiter = "####################";

        public Engine(IReader reader, IWriter writer, ICommandParser commandParser , ICommandProcessor commandProcessor)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandParser = commandParser;
            this.commandProcessor = commandProcessor;
            this.factory = OlympicsFactory.Instance;
            this.commitee = OlympicCommittee.Instance;
        }

        public void Run()
        {
            string commandLine = null;

            while ((commandLine = Console.ReadLine()) != "end")
            {
                try
                {
                    var command = this.commandParser.ParseCommand(commandLine);
                    if (command != null)
                    {
                        //this.commandProcessor.Add(command);
                        this.commandProcessor.ProcessSingleCommand(command);
                        this.writer.Write(Delimiter);
                    }
                }
                catch (Exception ex)
                {
                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                    }
                    this.writer.Write(string.Format("ERROR: {0}", ex.Message));
                }
            }
        }
    }
}
