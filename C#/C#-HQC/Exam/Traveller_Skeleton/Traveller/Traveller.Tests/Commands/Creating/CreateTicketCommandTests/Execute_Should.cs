using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;
using System.Collections.Generic;
using Traveller.Commands.Creating;
using System.Linq;

namespace Traveller.Tests.Commands.Creating.CreateTicketCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void CreateTicketAndAddItToDatabase_WhenParametersAreCorrect()
        {
            //Arrange
            var databaseMock = new Mock<IDatabase>();
            var travellerFactoryMock = new Mock<ITravellerFactory>();
            var ticketMock = new Mock<ITicket>();
            var journeyMock = new Mock<IJourney>();
            databaseMock.Setup(m => m.Journeys.Add(journeyMock.Object));

            List<ITicket> tickets = new List<ITicket>();
            databaseMock.SetupGet(m => m.Tickets).Returns(tickets);
            //databaseMock.Object.Tickets.
            List<string> commandLine = new List<string>()
            {
                "0",
                "30"
            };

            travellerFactoryMock.Setup(m => m.CreateTicket(journeyMock.Object, 0)).Returns(ticketMock.Object);
            var command = new CreateTicketCommand(databaseMock.Object, travellerFactoryMock.Object);

            //Act
            command.Execute(commandLine);

            //Assert
            Assert.AreEqual(1, databaseMock.Object.Tickets.Count);
            Assert.AreEqual(ticketMock.Object, databaseMock.Object.Tickets.First());
        }
    }
}
