using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;

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
            set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(this.Seats), Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return Convert.ToInt32(VehicleType.Car);
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
