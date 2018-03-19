using Bytes2you.Validation;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGames.Core.Commands
{
    public abstract class CreateOlympianCommand
    {
        private readonly IOlympicCommittee committee;
        private readonly IOlympicsFactory factory;

        protected CreateOlympianCommand(IOlympicCommittee committee, IOlympicsFactory factory)
        {
            Guard.WhenArgument(committee, "commettee").IsNull().Throw();
            Guard.WhenArgument(factory, "factory").IsNull().Throw();

            this.committee = committee;
            this.factory = factory;
        }

        protected string FirstName { get; private set; }

        protected string LastName { get; private set; }

        protected string Country { get; private set; }

        protected IOlympicCommittee Committee
        {
            get
            {
                return this.committee;
            }
        }

        protected IOlympicsFactory Factory
        {
            get
            {
                return this.factory;
            }
        }

        public virtual string Execute(IList<string> commandLine)
        {
            commandLine = commandLine.Take(3).ToList();

            commandLine.ValidateIfNull();

            if (commandLine.Count < 3)
            {
                throw new ArgumentException(GlobalConstants.ParametersCountInvalid);
            }

            this.FirstName = commandLine[0];
            this.LastName = commandLine[1];
            this.Country = commandLine[2];

            var olympian = this.CreatePerson();

            this.Committee.Olympians.Add(olympian);

            return string.Format("Created {0}\n{1}", olympian.GetType().Name, olympian);
        }

        protected abstract IOlympian CreatePerson();
    }
}
