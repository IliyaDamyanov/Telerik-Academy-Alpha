/*using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
            : base (factory,engine)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            return $"Vehicle with ID {this.Engine.Vehicles.Count-1} was created";
        }
    }
}*/
