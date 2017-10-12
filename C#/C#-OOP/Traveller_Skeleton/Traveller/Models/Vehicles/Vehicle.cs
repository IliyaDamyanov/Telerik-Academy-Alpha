using Traveller.Models.Utils;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private int passangerCapacity;
        public decimal pricePerKilometer;
        private VehicleType type;

        public Vehicle (int passengerCapacity, decimal pricePerKilometer)
        {
            this.PassangerCapacity = passengerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        public int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.PassangerCapacity)));

                Validator.ValidateIntRange(value, Constants.vehiclePassangerCapacityMin, Constants.vehiclePassangerCapacityMax, 
                    string.Format(Constants.vehiclePassangerCapacityMes, Constants.vehiclePassangerCapacityMin, Constants.vehiclePassangerCapacityMax));

                this.passangerCapacity = value;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.PricePerKilometer)));
                Validator.ValidateDecimalRange(value, Constants.vehiclePricePerKilometerMin, Constants.vehiclePricePerKilometerMax,
                    string.Format(Constants.vehiclePricePerKilometerMes, Constants.vehiclePricePerKilometerMin, Constants.vehiclePricePerKilometerMax));

                this.pricePerKilometer = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public abstract string VehicleName();

        public abstract string SpecificInformation();

        public override string ToString()
        {
            return string.Format(@"{0} ----
Passenger capacity: {1}
Price per kilometer: {2}
Vehicle type: {3}{4}", this.VehicleName(), this.PassangerCapacity, this.PricePerKilometer, this.Type,this.SpecificInformation());
        }
    }
}
