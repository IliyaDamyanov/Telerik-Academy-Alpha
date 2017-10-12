using System;
using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price,int weightCapacity) : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity, string.Concat(Constants.NumberMustBeBetweenMinAndMax, nameof(this.WeightCapacity), Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Truck;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Truck;
            }
        }

        protected override string GetVehicleSpecificText()
        {
            return string.Format("Weight Capacity: {0}", this.WeightCapacity);
        }
    }
}
