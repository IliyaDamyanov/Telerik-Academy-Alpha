using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using System.Collections.Generic;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : CreateOlympianCommand, ICommand
    {
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IOlympicCommittee committee, IOlympicsFactory factory)
            : base(committee, factory)
        {
            this.records = new Dictionary<string, double>();
        }

        public override string Execute(IList<string> commandLine)
        {
            foreach (var recordItem in commandLine)
            {
                var recordValue = recordItem.Split('/');
                this.records.Add(recordValue[0], double.Parse(recordValue[1]));
            }

            return base.Execute(commandLine);
        }

        protected override IOlympian CreatePerson()
        {
            return this.Factory.CreateSprinter(this.FirstName, this.LastName, this.Country, this.records);
        }
    }
}
