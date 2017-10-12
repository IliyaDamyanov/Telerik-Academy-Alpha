using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private bool hasFreeFood;
        public Airplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood) : base(passengerCapacity, pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
            this.Type = VehicleType.Air;
        }

        public bool HasFreeFood
        {
            get
            {
                return this.hasFreeFood;
            }
            private set
            {
                this.hasFreeFood = value;
            }
        }

        public override string SpecificInformation()
        {
            return string.Format(@"
Has free food: {0}", this.HasFreeFood);
        }

        public override string VehicleName()
        {
            return string.Format("{0}", nameof(Airplane));
        }
    }
}
