﻿using Ninject;
using Ninject.Modules;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;
using Traveller.Decorators;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IEngine>().To<Engine>().InSingletonScope();
            
            this.Bind<ICommandParser>().To<CommandParser>().InSingletonScope();
            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();
            
            this.Bind<IDatabase>().To<Database>().InSingletonScope();
            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("createairplane");
            this.Bind<ICommand>().To<CreateBusCommand>().Named("createbus");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("createjourney");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("createticket");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("createtrain");
            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");
            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");

            this.Bind<ICommandFactory>().To<CommandFactory>();
        }
    }
}
