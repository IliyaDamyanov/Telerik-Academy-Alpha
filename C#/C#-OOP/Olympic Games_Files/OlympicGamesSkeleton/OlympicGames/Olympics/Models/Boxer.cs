using System;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;

namespace OlympicGames.Olympics.Models
{
    public class Boxer : Olympian, IBoxer
    {
        private BoxingCategory category;
        private int losses;
        private int wins;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category, int wins, int losses) : base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.Losses = losses;
        }

        public BoxingCategory Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.Category)));

                this.category = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }
            private set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.Losses)));
                Validator.ValidateMinAndMaxNumber(value, Constants.MinLosses, Constants.MaxLosses, string.Format(Constants.MinAndMaxNumber, 
                    nameof(this.Losses), Constants.MinLosses, Constants.MaxLosses));

                this.losses = value;
            }
        }

        public int Wins
        {
            get
            {
                return this.wins;
            }
            private set
            {
                Validator.ValidateIfNull(value, string.Format(Constants.CannotBeNull, nameof(this.Wins)));
                Validator.ValidateMinAndMaxNumber(value, Constants.MinWins, Constants.MaxWins, string.Format(Constants.MinAndMaxNumber,
                    nameof(this.Wins), Constants.MinWins, Constants.MaxWins));
                
                this.wins = value;
            }
        }

        public override string OlympianData()
        {
            return string.Format(@"{0}: {1}
{2}: {3}
{4}: {5}", nameof(this.Category), this.Category, nameof(this.Wins), this.Wins, nameof(this.Losses), this.Losses);
        }

        public override string OlympianTypeToUpper()
        {
            return nameof(Boxer).ToUpper();
        }
    }
}
