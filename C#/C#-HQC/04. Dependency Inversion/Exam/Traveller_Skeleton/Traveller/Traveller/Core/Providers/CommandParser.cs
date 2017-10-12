﻿using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Core.Providers
{
    public class CommandParser : ICommandParser
    {
        private readonly ICommandFactory commandFactory;

        public CommandParser(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory ?? throw new ArgumentNullException("commandFactory");
        }
        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split()[0];
            
            return this.commandFactory.CreateCommand(commandName);
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split().Skip(1).ToList();
            if (commandParts.Count == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }
    }
}
