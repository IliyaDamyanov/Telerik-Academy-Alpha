using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OlympicGames.Core.Providers;
using Moq;
using OlympicGames.Core.Contracts;
using OlympicGames.Core;

namespace OlympicGames.Framework.UnitTests.Core.EngineTests
{
    [TestClass]
    public class Run_Should
    {
        [TestMethod]
        public void CallWriteMethodWithExeptionMessage_WhenExceptionIsThrown()
        {
            //Arrange
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var commandParserMock = new Mock<ICommandParser>();
            var commandProcessorMock = new Mock<ICommandProcessor>();
            var commandMock = new Mock<ICommand>();
            string exceptionMessage = "test";
            string messageToWrite = string.Format("ERROR: {0}", exceptionMessage);

            readerMock.SetupSequence(m => m.Read()).Returns("ome command").Returns("end");

            commandParserMock.Setup(m => m.ParseCommand(It.IsAny<string>())).Returns(commandMock.Object);

            commandProcessorMock.Setup(m => m.ProcessSingleCommand(commandMock.Object, It.IsAny<string>())).Throws(new Exception(exceptionMessage));

            var engine = new Engine(readerMock.Object, writerMock.Object, commandParserMock.Object, commandProcessorMock.Object);

            //Act
            engine.Run();

            //Assert
            writerMock.Verify(m => m.Write(messageToWrite), Times.Once);
        }
    }
}
