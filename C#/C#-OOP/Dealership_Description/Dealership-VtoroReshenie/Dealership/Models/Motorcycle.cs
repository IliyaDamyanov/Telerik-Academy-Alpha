using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private readonly string categoryInvalidMessage = string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Category), Constants.MinCategoryLength, Constants.MaxCategoryLength);
        private string category;

        public Motorcycle(string make, string model, decimal price,string category) : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateNull(value, "Category must not be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, this.categoryInvalidMessage);

                this.category = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Motorcycle;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Motorcycle;
            }
        }

        protected override string GetVehicleSpecificText()
        {
            return string.Format("Category: {0}", this.Category);
        }
    }
}
