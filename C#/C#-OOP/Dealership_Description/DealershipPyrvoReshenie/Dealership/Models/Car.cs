using System;
using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats) : base(make, model, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            private set
            {
                Validator.ValidateIntRange(value,Constants.MinSeats,Constants.MaxSeats,string.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(this.Make) , Constants.MinSeats,Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Car;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Car;
            }
        }

        protected override string GetVehicleSpecificText()
        {
            return string.Format("Seats: {0}", this.Seats);
        }
    }
}
