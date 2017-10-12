﻿using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Providers
{
    public class Database : IDatabase
    {
        private readonly List<IVehicle> vehicles;
        private readonly List<IJourney> journeys;
        private readonly List<ITicket> tickets;

        public Database()
        {
            this.vehicles = new List<IVehicle>();
            this.journeys = new List<IJourney>();
            this.tickets = new List<ITicket>();
        }

        public IList<ITicket> Tickets
        {
            get
            {
                return this.tickets;
            }
        }
        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
        }

        public IList<IJourney> Journeys
        {
            get
            {
                return this.journeys;
            }
        }
    }
}
