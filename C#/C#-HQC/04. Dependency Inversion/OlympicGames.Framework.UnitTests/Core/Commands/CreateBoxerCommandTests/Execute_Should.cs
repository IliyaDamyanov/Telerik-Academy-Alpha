using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OlympicGames.Core.Contracts;
using System.Collections.Generic;
using OlympicGames.Core.Commands;
using OlympicGames.Olympics.Contracts;
using System.Linq;

namespace OlympicGames.Framework.UnitTests.Core.Commands.CreateBoxerCommandTests
{
    [TestClass]
    public class Execute_Should
    {
        [TestMethod]
        public void CreateBoxerAndAddItToDatabase_WhenParametersAreCorrect()
        {
            //Arrange
            List<string> commandLine = new List<string>()
            {
                "category",
                "1",
                "1"
            };

            List<IOlympian> olympians = new List<IOlympian>();

            var databaseMock = new Mock<IOlympicCommittee>();
            var factoryMock = new Mock<IOlympicsFactory>();
            var boxerMock = new Mock<IOlympian>();

            factoryMock.Setup(m => m.CreateBoxer(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>())).Returns(boxerMock.Object);

            databaseMock.SetupGet(m => m.Olympians).Returns(olympians);

            var command = new CreateBoxerCommand(databaseMock.Object, factoryMock.Object);

            //Act
            command.Execute(commandLine);

            //Assert
            Assert.AreEqual(1, databaseMock.Object.Olympians.Count);
            Assert.AreEqual(boxerMock.Object, databaseMock.Object.Olympians.Single());
        }
    }
}
