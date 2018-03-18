using Bytes2you.Validation;
using OlympicGames.Core.Contracts;
using System;

namespace OlympicGames.Core.Providers
{
    public class CommandParser : ICommandParser
    {
        private readonly ICommandFactory commandFactory;

        public CommandParser(ICommandFactory commandFactory)
        {
            Guard.WhenArgument(commandFactory, "commandFactory").IsNull().Throw();

            this.commandFactory = commandFactory;
        }

        public ICommand ParseCommand(string commandLine)
        {
            var lineParameters = commandLine.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var commandName = lineParameters[0];

            return this.commandFactory.CreateCommand(commandName);

            //var typeInfo = FindCommand(commandName);
            //var command = Activator.CreateInstance(typeInfo, OlympicCommittee.Instance) as ICommand;
            //return command;
        }

        //private TypeInfo FindCommand(string commandName)
        //{
        //    Assembly commandAssembly = Assembly.GetAssembly(typeof(ICommand));

        //    var commandType = commandAssembly.DefinedTypes
        //        .Where(x => x.ImplementedInterfaces.Any(y => y == typeof(ICommand)))
        //        .Where(x => !x.IsAbstract)
        //        .SingleOrDefault(x => x.Name.ToLower() == (commandName.ToLower() + "command"));

        //    if (commandType == null)
        //    {
        //        throw new ArgumentException("No such command implemented! Consider implementing it before using!");
        //    }

        //    return commandType;
        //}

        //#region DoNotTouch
        //private void CheckForBaseClassImplementation(string commandName)
        //{
        //    if (commandName == "checkbaseclass")
        //    {
        //        var assembly = Assembly.GetAssembly(typeof(IOlympian));
        //        var baseClass = assembly.DefinedTypes.Where(type => type.IsAbstract)
        //            .Where(x => x.IsClass)
        //            .FirstOrDefault(x => x.ImplementedInterfaces.Contains(typeof(IOlympian)));

        //        if (baseClass != null)
        //        {
        //            throw new ArgumentException("BASE CLASS FOUND");
        //        }
        //    }
        //}

        //private void CheckForBaseClassTwoDerivedClasses(string commandName)
        //{
        //    if (commandName == "checkbaseclassderived")
        //    {
        //        var assembly = Assembly.GetAssembly(typeof(IOlympian));
        //        var baseClass = assembly.DefinedTypes.Where(type => type.IsAbstract)
        //            .Where(x => x.IsClass)
        //            .FirstOrDefault(x => x.ImplementedInterfaces.Contains(typeof(IOlympian)));

        //        var baseClassesInheritans = assembly.DefinedTypes.Where(type => type.IsSubclassOf(baseClass)).Where(x => !x.IsAbstract);

        //        throw new ArgumentException(string.Format("BASE CLASS DERIVED COUNT: {0}", baseClassesInheritans.Count()));
        //    }
        //}
        //#endregion
    }
}
