namespace Traveller.Models.Utils
{
    public class Constants
    {
        // ints
        public const int vehiclePassangerCapacityMin = 1;
        public const int vehiclePassangerCapacityMax = 800;
        public const int trainCartsMin = 1;
        public const int trainCartsMax = 15;
        public const int trainPassangerCapacityMin = 30;
        public const int trainPassangerCapacityMax = 150;
        public const int busPassangerCapacityMin = 10;
        public const int busPassangerCapacityMax = 50;
        public const int distanceMin = 5;
        public const int distanceMax = 5000;

        //string lenghts
        public const int startLocationAndDestinationMinLenght = 5;
        public const int startLocationAndDestinationMaxLenght = 25;

        // decimals
        public const decimal vehiclePricePerKilometerMin = 0.1m;
        public const decimal vehiclePricePerKilometerMax = 2.5m;

        //messages
        public const string CannotBeNull = "{0} can't be null.";

        public const string vehiclePassangerCapacityMes = "A vehicle with less than {0} passengers or more than {1} passengers cannot exist!";
        public const string vehiclePricePerKilometerMes = "A vehicle with a price per kilometer lower than ${0:F2} or higher than ${1:F2} cannot exist!";
        public const string trainCartsMes = "A train cannot have less than {0} cart or more than {1} carts.";
        public const string trainPassangerCapacityMes = "A train cannot have less than {0} passengers or more than {1} passengers.";
        public const string busPassangerCapacityMes = "A bus cannot have less than {0} passengers or more than {1} passengers.";
        public const string startingLocationLenghtMes = "The StartingLocation's length cannot be less than {0} or more than {1} symbols long.";
        public const string destinationLenghtMes = "The {0}'s length cannot be less than {1} or more than {2} symbols long.";
        public const string distanceMes = "The {0} cannot be less than {1} or more than {2} kilometers.";
    }
}
