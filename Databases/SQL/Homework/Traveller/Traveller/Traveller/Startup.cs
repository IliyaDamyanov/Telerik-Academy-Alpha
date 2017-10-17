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
                //    var tickets = context.Tickets.ToList();
                //    System.Console.WriteLine(string.Join("\n", tickets.Select(t => t.AdministrativeCosts)));

                //Journey journey = new Journey();
                //journey.StartLocation = "Sofiq";
                //journey.Destination = "Silistra";
                //journey.Distance = 5400;

                //try
                //{
                //    context.Journeys.Add(journey);
                //    context.SaveChanges();
                //}
                //catch 
                //{

                //}

                //Ticket ticket = new Ticket();
                //ticket.AdministrativeCosts = 1400;
                //ticket.Journey = journey;

                //context.Tickets.Add(ticket);
                //context.SaveChanges();

                var ticket = context.Tickets.ToList().First();
                System.Console.WriteLine(ticket.Journey);
                //context.SaveChanges();
            }

            //IKernel kernel = new StandardKernel(new TravellerModule());

            //IEngine engine = kernel.Get<IEngine>("Engine");
            //engine.Start();
        }
    }
}
