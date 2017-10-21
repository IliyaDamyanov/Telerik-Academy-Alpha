using System.Collections.Generic;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Contracts
{
    public interface IDatabase
    {
        IList<ITicket> Tickets { get; }
        IList<IVehicle> Vehicles { get; }
        IList<IJourney> Journeys { get; }
}
}
