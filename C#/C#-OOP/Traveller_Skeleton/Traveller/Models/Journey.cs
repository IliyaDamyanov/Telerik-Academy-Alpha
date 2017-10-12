using System;
using Traveller.Models.Contracts;
using Traveller.Models.Utils;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Journey : IJourney
    {
        private string startLocation;
        private string destination;
        private int distance;
        private IVehicle vehicle;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            this.StartLocation = startLocation;
            this.Destination = destination;
            this.Distance = distance;
            this.Vehicle = vehicle;
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.startLocationAndDestinationMinLenght, 
                    Constants.startLocationAndDestinationMaxLenght, string.Format(Constants.destinationLenghtMes, 
                    nameof(this.Destination), Constants.startLocationAndDestinationMinLenght, Constants.startLocationAndDestinationMaxLenght));

                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }
            private set
            {
                Validator.ValidateIntRange(value, Constants.distanceMin, Constants.distanceMax, 
                    string.Format(Constants.distanceMes, nameof(this.Distance), Constants.distanceMin, Constants.distanceMax));

                this.distance = value;
            }
        }

        public string StartLocation
        {
            get
            {
                return this.startLocation;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.startLocationAndDestinationMinLenght, 
                    Constants.startLocationAndDestinationMaxLenght, string.Format(Constants.startingLocationLenghtMes, 
                    Constants.startLocationAndDestinationMinLenght, Constants.startLocationAndDestinationMaxLenght));

                this.startLocation = value;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }
            private set
            {
                this.vehicle = value;
            }
        }

        public decimal CalculateTravelCosts()
        {
            return this.Distance * this.Vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            return string.Format(@"{0} ----
Start location: {1}
Destination: {2}
Distance: {3}
Vehicle type: {4}
Travel costs: {5}", nameof(Journey), this.StartLocation, this.Destination, this.Distance, this.Vehicle.Type, this.CalculateTravelCosts());
        }
    }
}
