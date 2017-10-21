using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly ITravellerFactory travellerFactory;

        public CreateTrainCommand (IDatabase database)
        {
            this.database = database ?? throw new ArgumentNullException("database");
            this.travellerFactory = travellerFactory ?? throw new ArgumentNullException("travellerFactory");
        }

        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.travellerFactory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.database.Vehicles.Add(train);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
