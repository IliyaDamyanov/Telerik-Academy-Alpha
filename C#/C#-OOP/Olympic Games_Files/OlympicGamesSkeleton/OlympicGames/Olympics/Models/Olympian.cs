using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Models
{
    public abstract class Olympian : IOlympian
    {
        private const string firstNameConst = "First name";
        private const string lastNameConst = "Last name";
        private string firstName;
        private string lastName;
        private string country;

        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.FirstName)));
                Validator.ValidateMinAndMaxLength(value, Constants.OlympianFirstNameMinLength, Constants.OlympianFirstNameMaxLength,
                    string.Format(Constants.MinAndMaxLenght, firstNameConst, Constants.OlympianFirstNameMinLength, 
                    Constants.OlympianFirstNameMaxLength));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.LastName)));
                Validator.ValidateMinAndMaxLength(value, Constants.OlympianLastNameMinLength, Constants.OlympianLastNameMaxLength,
                    string.Format(Constants.MinAndMaxLenght, lastNameConst, Constants.OlympianLastNameMinLength,
                    Constants.OlympianLastNameMaxLength));

                this.lastName = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.Country)));
                Validator.ValidateMinAndMaxLength(value, Constants.OlympianCountryMinLength, Constants.OlympianCountryMaxLength,
                    string.Format(Constants.MinAndMaxLenght, nameof(this.Country), Constants.OlympianCountryMinLength,
                    Constants.OlympianCountryMaxLength));

                this.country = value;
            }
        }

        public abstract string OlympianTypeToUpper();

        public abstract string OlympianData();

        public override string ToString()
        {
            return string.Format(@"{0}: {1} {2} from {3}
{4}", this.OlympianTypeToUpper(), this.FirstName, this.LastName, this.Country, this.OlympianData());
        }
    }
}
