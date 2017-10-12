using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly ITravellerFactory travellerFactory;

        public CreateTicketCommand(IDatabase database, ITravellerFactory travellerFactory)
        {
            this.database = database ?? throw new ArgumentNullException("database");
            this.travellerFactory = travellerFactory ?? throw new ArgumentNullException("travellerFactory");
        }

        public string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = this.database.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.travellerFactory.CreateTicket(journey, administrativeCosts);
            this.database.Tickets.Add(ticket);

            return $"Ticket with ID {this.database.Tickets.Count - 1} was created.";
        }
    }
}
