using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System.Linq;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand : CreateOlympianCommand, ICommand
    {
        private string category;
        private int wins;
        private int losses;

        public CreateBoxerCommand(IOlympicCommittee committee, IOlympicsFactory factory)
            : base(committee, factory)
        {
        }

        public override string Execute(IList<string> commandLine)
        {
            //var current = commandLine.Skip(4).ToList();

            if (commandLine.Count != 3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }

            this.category = commandLine[0];

            bool checkWins = int.TryParse(commandLine[1], out this.wins);
            bool checkLosses = int.TryParse(commandLine[2], out this.losses);

            if (!checkWins || !checkLosses)
            {
                throw new ArgumentException(GlobalConstants.WinsLossesMustBeNumbers);
            }

            return base.Execute(commandLine);
        }

        protected override IOlympian CreatePerson()
        {
           return this.Factory.CreateBoxer(this.FirstName, this.LastName, this.Country, this.category, this.wins, this.losses);
        }
    }
}
