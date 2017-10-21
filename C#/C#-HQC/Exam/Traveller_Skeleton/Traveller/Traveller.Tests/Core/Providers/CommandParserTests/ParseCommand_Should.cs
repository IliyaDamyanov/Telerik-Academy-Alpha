using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Traveller.Core.Providers;
using Moq;
using Traveller.Core.Contracts;
using Traveller.Commands.Contracts;

namespace Traveller.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class ParseCommand_Should
    {
        [TestMethod]
        [DataRow("createbus 10 0.7")]
        [DataRow("createtrain 300 0.4 3")]
        [DataRow("createairplane 250 1 true")]
        [DataRow("listvehicles")]
        [DataRow("createjourney Sofia vTurnovo 300 0")]
        [DataRow("createticket 0 30")]
        public void ParseCommandReturnsCommand_WhenParametersAreCorrect(string fullCommand)
        {
            //Assert
            var commandFactoryMock = new Mock<ICommandFactory>();
            var commandParser = new CommandParser(commandFactoryMock.Object);

            //Act
            var command = commandParser.ParseCommand(fullCommand);

            //Assert
            Assert.IsNotNull(command);
        }
    }
}
