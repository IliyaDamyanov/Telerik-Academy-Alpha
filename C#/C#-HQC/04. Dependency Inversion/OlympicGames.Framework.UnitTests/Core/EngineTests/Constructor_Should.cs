using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OlympicGames.Core.Providers;
using Moq;
using OlympicGames.Core;
using OlympicGames.Core.Contracts;

namespace OlympicGames.Framework.UnitTests.Core.EngineTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ReturnInstance_WhenParametersAreCorrect()
        {
            //Arrange
            var readerMock = new Mock<IReader>();
            var writerMock = new Mock<IWriter>();
            var commandParserMock = new Mock<ICommandParser>();
            var commandProcessorMock = new Mock<ICommandProcessor>();

            //Act
            var engine = new Engine(readerMock.Object, writerMock.Object, commandParserMock.Object, commandProcessorMock.Object);

            //Assert
            Assert.IsNotNull(engine);
        }

        [TestMethod]
        public void ThrowException_WhenReaderArgumentIsNull()
        {
            //Arrange
            var writerMock = new Mock<IWriter>();
            var commandParserMock = new Mock<ICommandParser>();
            var commandProcessorMock = new Mock<ICommandProcessor>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(null, writerMock.Object, commandParserMock.Object, commandProcessorMock.Object));
        }

        [TestMethod]
        public void ThrowException_WhenWriterArgumentIsNull()
        {
            //Arrange
            var readerMock = new Mock<IReader>();
            var commandParsererMock = new Mock<ICommandParser>();
            var commandProcessorMock = new Mock<ICommandProcessor>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new Engine(readerMock.Object, null, commandParsererMock.Object, commandProcessorMock.Object));
        }
    }
}
