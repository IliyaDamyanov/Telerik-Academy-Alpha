using Traveller.Models.Contracts;

namespace Traveller.Models
{
    public class Ticket : ITicket
    {
        private decimal administrativeCosts;
        private IJourney journey;

        public Ticket(IJourney journey, decimal administrativeCosts)
        {
            this.Journey = journey;
            this.AdministrativeCosts = administrativeCosts;
        }

        public decimal AdministrativeCosts
        {
            get
            {
                return this.administrativeCosts;
            }
            private set
            {
                this.administrativeCosts = value;
            }
        }

        public IJourney Journey
        {
            get
            {
                return this.journey;
            }
            private set
            {
                this.journey = value;
            }
        }

        public decimal CalculatePrice()
        {
            return this.AdministrativeCosts + this.Journey.CalculateTravelCosts();
        }

        public override string ToString()
        {
            return string.Format(@"{0} ----
{1}: {2}
Price: {3}", nameof(Ticket), nameof(this.Journey.Destination), this.Journey.Destination, this.CalculatePrice());
        }
    }
}
