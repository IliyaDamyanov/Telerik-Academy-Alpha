using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Utilities.UnitTest.StringUtilitiesTests
{
    [TestClass]
    public class ReverseString_Should
    {
        [TestMethod]
        [DataRow("Test 1234@", "@4321 tseT")]
        [DataRow("TeT", "TeT")]
        public void ReturnReversedString_WhenParameterIsCorrect(string textToReverse, string expectedResult)
        {
            //Arrange
            StringUtilities stringUtilities = new StringUtilities();

            //Act
            string result = stringUtilities.ReverseString(textToReverse);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ReturnEmptyString_WhenParameterIsEmptyString()
        {
            //Arrange
            string textToReverse = string.Empty;
            StringUtilities stringUtilities = new StringUtilities();

            string expectedResult = string.Empty;

            //Act
            string result = stringUtilities.ReverseString(textToReverse);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenParameterIsNull()
        {
            //Arrange
            string textToReverse = null;
            StringUtilities stringUtilities = new StringUtilities();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => stringUtilities.ReverseString(textToReverse));
        }
    }
}
