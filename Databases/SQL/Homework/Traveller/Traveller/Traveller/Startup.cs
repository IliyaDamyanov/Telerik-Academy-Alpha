using Ninject;
using System.Data.Entity;
using Traveller.Core;
using Traveller.Data;
using Traveller.Migrations;
using Traveller.Ninject;
using System.Linq;
using Traveller.Models;

namespace Traveller
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravellerContext, Configuration>());

            using (var context = new TravellerContext())
            {
                Ticket ticket = new Ticket();
                ticket.AdministrativeCosts = 200;

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }

            //IKernel kernel = new StandardKernel(new TravellerModule());

            //IEngine engine = kernel.Get<IEngine>("Engine");
            //engine.Start();
        }
    }
}
