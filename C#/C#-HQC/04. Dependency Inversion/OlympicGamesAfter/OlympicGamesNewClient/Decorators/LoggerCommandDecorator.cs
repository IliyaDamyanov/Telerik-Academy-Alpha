using OlympicGames.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace OlympicGamesNewClient.Decorators
{
    public class LoggerCommandDecorator : ICommand
    {
        private readonly ICommand command;

        public LoggerCommandDecorator(ICommand command)
        {
            this.command = command;
        }
        public string Execute(IList<string> commandLine)
        {
            string result = null;
            using (StreamWriter streamWriter = new StreamWriter("logFile.txt", true))
            {
                Stopwatch stopwatch = new Stopwatch();

                streamWriter.WriteLine($"Command is executing at {DateTime.Now}");
                stopwatch.Start();
                result = this.command.Execute(commandLine);
                stopwatch.Stop();
                streamWriter.WriteLine($"Command finished executing at {DateTime.Now} and took {stopwatch.ElapsedTicks}");
            }

            return result;
        }
    }
}
