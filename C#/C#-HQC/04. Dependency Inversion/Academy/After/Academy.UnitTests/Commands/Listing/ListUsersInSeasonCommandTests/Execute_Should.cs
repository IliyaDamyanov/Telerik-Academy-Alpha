using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Academy.Core.Contracts;
using Academy.Models.Contracts;
using System.Collections.Generic;
using Academy.Commands.Listing;

namespace Academy.UnitTests.Commands.Listing.ListUsersInSeasonCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void ReturnStringRepresentingUsers_WhenParametersAreCorrect()
        {
            //Arrange
            var factoryMok = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();
            var firstSeasonMock = new Mock<ISeason>();
            var secondSeasonMock = new Mock<ISeason>();
            List<ISeason> seasons = new List<ISeason>()
            {
                firstSeasonMock.Object,
                secondSeasonMock.Object
            };

            List<string> parameters = new List<string>()
            {
                "1"
            };

            string expectedResult = "listing users";

            engineMock.SetupGet(m => m.Seasons).Returns(seasons);
            secondSeasonMock.Setup(m => m.ListUsers()).Returns(expectedResult);

            ListUsersInSeasonCommand command = new ListUsersInSeasonCommand(factoryMok.Object, engineMock.Object);

            //Act
            var result = command.Execute(parameters);

            //Assert
            secondSeasonMock.Verify(m => m.ListUsers(), Times.Once());
            Assert.AreEqual(expectedResult, result);
        }
    }
}
