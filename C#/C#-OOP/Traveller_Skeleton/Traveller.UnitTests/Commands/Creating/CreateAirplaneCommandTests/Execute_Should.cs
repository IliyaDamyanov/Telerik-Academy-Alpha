
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.UnitTests.Commands.Creating.CreateAirplaneCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        private const string SuccessMessageTemplate = "Vehicle with ID {0} was created.";

        [TestMethod]
        public void ReturnSuccessMessage_WhenParametersAreCorrect()
        {
            // Arrange
            List<string> parameters = new List<string>();
            parameters.Add("250");
            parameters.Add("2.0");
            parameters.Add("true");

            List<IVehicle> vehicles = new List<IVehicle>();
            var engineMock = new Mock<IEngine>();
            engineMock.SetupGet(e => e.Vehicles).Returns(vehicles);

            string result = string.Format(SuccessMessageTemplate, 0);
            CreateAirplaneCommand command =
                new CreateAirplaneCommand(TravellerFactory.Instance, engineMock.Object);

            // Act
            string actualResult = command.Execute(parameters);

            // Assert
            Assert.AreEqual(result, actualResult);
            engineMock.VerifyGet(e => e.Vehicles, Times.Exactly(2));
        }

        [TestMethod]
        [DataRow("invalid capacity", "2.0", "true")]
        [DataRow("250", "invalid price", "true")]
        [DataRow("250", "2.0", "invalid boolean")]
        public void ThrowException_WhenParametersAreNotCorrect(string passangerCapacity,
            string pricePerKilometer, string hasFreeFood)
        {
            // Arrange
            List<string> parameters = new List<string>()
            { passangerCapacity, pricePerKilometer, hasFreeFood };

            CreateAirplaneCommand command =
                new CreateAirplaneCommand(TravellerFactory.Instance, Engine.Instance);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => command.Execute(parameters));
        }
    }
}
