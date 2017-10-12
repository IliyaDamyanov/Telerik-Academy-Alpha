namespace OlympicGames.Olympics.Models
{
    public class Constants
    {
        //strings
        public const string firstNameKey = "firstname";
        public const string lastNameKey = "lastname";
        public const string lastNamecountry = "country";
        public const string orderAsc = "asc";
        public const string orderDesc = "desc";

        // String lengths
        public const int OlympianFirstNameMinLength = 2;
        public const int OlympianFirstNameMaxLength = 20;
        public const int OlympianLastNameMinLength = 2;
        public const int OlympianLastNameMaxLength = 20;
        public const int OlympianCountryMinLength = 3;
        public const int OlympianCountryMaxLength = 25;

        // Numbers validation
        public const int MinWins = 0;
        public const int MaxWins = 100;
        public const int MinLosses = 0;
        public const int MaxLosses = 100;

        public const string CannotBeNull= "{0} cannot be null!";
        public const string CannotParse = "{0} was not parsed!";
        public const string MinAndMaxLenght = "{0} must be between {1} and {2} characters long!";
        public const string MinAndMaxNumber = "{0} must be between {1} and {2}!";       
    }
}
