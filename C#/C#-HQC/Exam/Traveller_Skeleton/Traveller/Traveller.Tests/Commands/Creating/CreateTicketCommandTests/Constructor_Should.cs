using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Providers;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;

namespace Traveller.Tests.Commands.Creating.CreateTicketCommandTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnInstance_WhenParametersAreCorrect()
        {
            //Arrange
            var databaseMock = new Mock<IDatabase>();
            var travellerFactoryMock = new Mock<ITravellerFactory>();

            //Act
            var createTicketCommand = new CreateTicketCommand(databaseMock.Object, travellerFactoryMock.Object);

            //Assert
            Assert.IsNotNull(createTicketCommand);
        }

        [TestMethod]
        public void ThrowException_WhenDatabaseArgumentIsNull()
        {
            //Arrange
            var travellerFactoryMock = new Mock<ITravellerFactory>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CreateTicketCommand(null, travellerFactoryMock.Object));
        }

        [TestMethod]
        public void ThrowException_WhenTravellerFactoryArgumentIsNull()
        {
            //Arrange
            var databaseMock = new Mock<IDatabase>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new CreateTicketCommand(databaseMock.Object, null));
        }
    }
}
