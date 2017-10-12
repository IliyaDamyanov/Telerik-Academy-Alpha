using Traveller.Models.Utils;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Train : Vehicle, ITrain
    {
        private int carts;

        public Train(int passengerCapacity, decimal pricePerKilometer, int carts) : base(passengerCapacity, pricePerKilometer)
        {
            Validator.ValidateIntRange(passengerCapacity, Constants.trainPassangerCapacityMin, Constants.trainPassangerCapacityMax, 
                string.Format(Constants.trainPassangerCapacityMes, Constants.trainPassangerCapacityMin, Constants.trainPassangerCapacityMax));

            this.Type = VehicleType.Land;
            this.Carts = carts;
        }

        public int Carts
        {
            get
            {
                return this.carts;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Carts)));
                Validator.ValidateIntRange(value, Constants.trainCartsMin, Constants.trainCartsMax,
                    string.Format(Constants.trainCartsMes, Constants.trainCartsMin, Constants.trainCartsMax));

                this.carts = value;
            }
        }

        public override string SpecificInformation()
        {
            return string.Format(@"
Carts amount: {0}", this.Carts);
        }

        public override string VehicleName()
        {
            return string.Format("{0}", nameof(Train));
        }
    }
}
