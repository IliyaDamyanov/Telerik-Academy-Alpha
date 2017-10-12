using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Factories;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Models;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : Command
    {
        public CreateBoxerCommand(IList<string> commandLine) : base(commandLine)
        {
            if (this.CommandParameters.Count!=6)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }
        }

        public override string Execute()
        {
            int winsParsed;
            int lossesParsed;
            if (!int.TryParse(this.CommandParameters[4], out winsParsed) || !int.TryParse(this.CommandParameters[5], out lossesParsed))
            {
                throw new ArgumentException(GlobalConstants.WinsLossesMustBeNumbers);
            }

            IOlympian olympian = OlympicsFactory.Instance.CreateBoxer(this.CommandParameters[0], this.CommandParameters[1],
                this.CommandParameters[2], this.CommandParameters[3], winsParsed, lossesParsed);
            this.Committee.Olympians.Add(olympian);
            return string.Format(@"Created {0}
{1}", nameof(Boxer),olympian.ToString());
        }
    }
}
