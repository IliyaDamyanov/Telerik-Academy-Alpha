using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Collections.Generic;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle , ICommentable
    {
        private int wheels;
        private string make;
        private string model;
        private IList<IComment> comments;
        private decimal price;
        
        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                Validator.ValidateNull(value, "Make must not be null.");
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.Make), Constants.MinMakeLength, Constants.MaxMakeLength));

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.ValidateNull(value, "Model must not be null.");
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.Model), Constants.MinModelLength, Constants.MaxModelLength));

                this.model = value;
            }
        }

        public abstract int Wheels { get; }

        public abstract VehicleType Type { get; }

        

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                Validator.ValidateNull(value, "Comments should not be null!");

                this.comments = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.ValidateNull(value, "Price must not be null.");
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"{0}:
  Make: {1}
            Model: {2}
            Wheels: {3}
            Price: ${4}
{5}
{6}", this.Type, this.Make, this.Model, this.Wheels, this.Price, this.GetVehicleSpecificText(),this.Comments.Count>0 ? string.Format(@"--COMMENTS--
{0}
--COMMENTS--",string.Join("\n", this.Comments)) : "--NO COMMENTS--");
        }

        protected abstract string GetVehicleSpecificText();
    }
}
