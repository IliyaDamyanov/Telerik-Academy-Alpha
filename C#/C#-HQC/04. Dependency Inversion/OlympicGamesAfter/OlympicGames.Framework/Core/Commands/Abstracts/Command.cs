//using System.Collections.Generic;

//using OlympicGames.Core.Contracts;
//using OlympicGames.Core.Factories;
//using OlympicGames.Core.Providers;

//namespace OlympicGames.Core.Commands.Abstracts
//{
//    public abstract class Command : ICommand
//    {
//        public Command()
//        {
//            this.Committee = OlympicCommittee.Instance;
//            this.Factory = OlympicsFactory.Instance;
//        }

//        public OlympicCommittee Committee { get; }

//        public IOlympicsFactory Factory { get; }

//        public abstract string Execute(IList<string> commandLine);
//    }
//}
