using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Contracts;
using Traveller.Core.Providers;

namespace Traveller.Tests.Core.Providers.CommandParserTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnInstance_WhenParametersAreCorrect()
        {
            //Arrange
            var commandFactoryMock = new Mock<ICommandFactory>();

            //Act
            var commandParser = new CommandParser(commandFactoryMock.Object);

            //Assert
            Assert.IsNotNull(commandParser);
        }

        [TestMethod]
        public void ThrowException_WhenCommandFactoryArgumentIsNull()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CommandParser(null));
        }
    }
}
