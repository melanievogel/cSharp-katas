using CSharp_Katas._7Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests._7Kyu
{
    [TestClass]
    public class TwoDimensionalArrayOperationTests
    {
        
        [TestMethod]
        public void Result_Should_Return_4()
        {
            // Arrange
            var input = new int[,] {{4}};
            var expected = 4;

            // Act
            var actual = TwoDimensionalArrayOperation.Result(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Result_Should_Return_21()
        {
            // Arrange
            var input = new int[,] { { 1, 2 }, { 3, 4 } };
            var expected = 21;

            // Act
            var actual = TwoDimensionalArrayOperation.Result(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Result_Should_Return_5376()
        {
            // Arrange
            var input = new int[,] { { 7, 1, 5, 8 }, { 2, 1, 4, 9 }, { 3, 2, 4, 7 } };
            var expected = 5376;

            // Act
            var actual = TwoDimensionalArrayOperation.Result(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
