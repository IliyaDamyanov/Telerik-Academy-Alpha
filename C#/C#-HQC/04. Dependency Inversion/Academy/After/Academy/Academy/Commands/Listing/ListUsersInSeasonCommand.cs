using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;

namespace Academy.Commands.Listing
{
    public class ListUsersInSeasonCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersInSeasonCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory ?? throw new ArgumentNullException("factory");
            this.engine = engine ?? throw new ArgumentNullException("engine");
        }

        public string Execute(IList<string> parameters)
        {
            var seasonId = parameters[0];
            var season = this.engine.Seasons[int.Parse(seasonId)];

            return season.ListUsers();
        }
    }
}
