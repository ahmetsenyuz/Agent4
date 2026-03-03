using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNormalCase()
        {
            // Arrange
            int input = 5;
            
            // Act & Assert
            Assert.IsTrue(input > 0);
        }

        [TestMethod]
        public void TestEdgeCaseOne()
        {
            // Arrange
            int input = 1;
            
            // Act & Assert
            Assert.IsTrue(input > 0);
        }

        [TestMethod]
        public void TestEdgeCaseTwo()
        {
            // Arrange
            int input = 2;
            
            // Act & Assert
            Assert.IsTrue(input > 0);
        }

        [TestMethod]
        public void TestInvalidInputNegative()
        {
            // Arrange
            int input = -5;
            
            // Act & Assert
            Assert.IsFalse(input > 0);
        }

        [TestMethod]
        public void TestInvalidInputZero()
        {
            // Arrange
            int input = 0;
            
            // Act & Assert
            Assert.IsFalse(input > 0);
        }

        [TestMethod]
        public void TestInvalidInputNonInteger()
        {
            // Arrange
            string input = "abc";
            
            // Act & Assert
            Assert.ThrowsException<FormatException>(() => int.Parse(input));
        }
    }
}