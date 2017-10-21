using System;
using System.Collections.Generic;
using System.Text;
using Traveller.Core.Contracts;
using Traveller.Core.Providers;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";

        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandParser parser;


        private StringBuilder Builder = new StringBuilder();

        public Engine(IReader reader, IWriter writer , ICommandParser parser)
        {
            this.reader = reader ?? throw new ArgumentNullException("reader");
            this.writer = writer ?? throw new ArgumentNullException("writer");
            this.parser = parser ?? throw new ArgumentNullException("parser");
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.Read();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(this.Builder.ToString());
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.Builder.AppendLine(ex.Message);
                }
            }
        }

        private void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var parser = this.parser;
            var command = parser.ParseCommand(commandAsString);
            var parameters = parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            this.Builder.AppendLine(executionResult);
        }
    }
}
