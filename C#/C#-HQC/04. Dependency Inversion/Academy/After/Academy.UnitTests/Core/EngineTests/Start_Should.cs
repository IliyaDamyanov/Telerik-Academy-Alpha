using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Academy.Core.Contracts;
using Academy.Commands.Contracts;
using System.Collections.Generic;
using System.Text;
using Academy.Core;

namespace Academy.UnitTests.Core.EngineTests
{
    [TestClass]
    public class Start_Should
    {
        [TestMethod]
        public void CallWriterWriteMethodWithCommandsResults_WhenInputIsCorrect()
        {
            //Arrange
            string commandInput = "CreateSeason 2016 2017 SoftwareAcademy";
            string exitCommand = "Exit";
            string commandResult = "command result";
            StringBuilder builder = new StringBuilder();
            builder.Append(commandResult);
            string expectedResult = builder.ToString();

            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var parserMock = new Mock<IParser>();
            var commandMock = new Mock<ICommand>();

            readerMock.SetupSequence(m => m.ReadLine()).Returns(commandInput).Returns(exitCommand);
            parserMock.Setup(m => m.ParseCommand(commandInput)).Returns(commandMock.Object);
            commandMock.Setup(m => m.Execute(It.IsAny<IList<string>>())).Returns(commandResult);

            Engine engine = new Engine(readerMock.Object, writerMock.Object, parserMock.Object);

            //Act
            engine.Start();

            //Assert
            writerMock.Verify(m => m.Write(expectedResult), Times.Once());
        }
        // Trqbwave da raboti toq unit test ama... (Viktor go pisa na klipa i raboteshe)
    }
}
