using Traveller.Models.Utils;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus
    {
        public Bus(int passengerCapacity, decimal pricePerKilometer) : base(passengerCapacity, pricePerKilometer)
        {
            Validator.ValidateIntRange(passengerCapacity, Constants.busPassangerCapacityMin, Constants.busPassangerCapacityMax, 
                string.Format(Constants.busPassangerCapacityMes, Constants.busPassangerCapacityMin, Constants.busPassangerCapacityMax));
            this.Type = VehicleType.Land;
        }

        public override string SpecificInformation()
        {
            return string.Empty;
        }

        public override string VehicleName()
        {
            return string.Format("{0}", nameof(Bus));
        }
    }
}
