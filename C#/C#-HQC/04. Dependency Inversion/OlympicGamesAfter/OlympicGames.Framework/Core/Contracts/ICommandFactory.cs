﻿namespace OlympicGames.Core.Contracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName);
    }
}
