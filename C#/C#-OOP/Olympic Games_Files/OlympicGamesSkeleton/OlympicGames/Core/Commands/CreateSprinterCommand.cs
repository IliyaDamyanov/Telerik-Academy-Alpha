using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Models;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : Command
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IList<string> commandLine) : base(commandLine)
        {
            if (this.CommandParameters.Count <3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
            else if (this.CommandParameters.Count == 3)
            {
                this.records = null;
            }
            else
            {
                this.records = new Dictionary<string, double>();
                for (int i = 3; i < commandLine.Count; i++)
                {
                    string[] Pair = commandLine[i].Split('/');
                    double parsedDouble;
                    if (!double.TryParse(Pair[1], out parsedDouble))
                    {
                        throw new ArgumentException(Constants.CannotParse, nameof(Pair));
                    }
                    this.records.Add(Pair[0], parsedDouble);
                }
            }
        }
        public override string Execute()
        {
            IOlympian olympian = OlympicsFactory.Instance.CreateSprinter(this.CommandParameters[0], this.CommandParameters[1],
            this.CommandParameters[2], this.records);
            this.Committee.Olympians.Add(olympian);
            return string.Format(@"Created {0}
{1}", nameof(Sprinter), olympian.ToString());
        }
    }
}
