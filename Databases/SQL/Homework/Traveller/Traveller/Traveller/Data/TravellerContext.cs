using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models;

namespace Traveller.Data
{
    public class TravellerContext : DbContext, ITravellerContext
    {
        public TravellerContext ()
            : base("TravellerConnection")
        {
        }

        public IDbSet<Ticket> Tickets { get; set; }


        public IDbSet<Journey> Journeys { get; set; }
    }
}
