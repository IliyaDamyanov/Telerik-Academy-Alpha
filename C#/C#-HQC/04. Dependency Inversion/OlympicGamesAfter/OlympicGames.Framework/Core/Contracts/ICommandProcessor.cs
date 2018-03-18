using System.Collections.Generic;

namespace OlympicGames.Core.Contracts
{
    public interface ICommandProcessor 
    {
        ICollection<ICommand> Commands { get; }

        void Add(ICommand command);

        void ProcessCommands(string commandLine);

        void ProcessSingleCommand(ICommand command, string commandLine);
    }
}
