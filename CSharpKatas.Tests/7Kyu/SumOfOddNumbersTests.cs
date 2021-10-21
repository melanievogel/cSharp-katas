using CSharp_Katas._7Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests._7Kyu
{
    [TestClass]
    public class SumOfOddNumbersTests
    {
        /*
         *              1
         *             3 5
         *            7 9 11
         *         13 15 17 19
         *        ...
         */
        [DataRow(1, 1)]
        [DataRow(2, 8)]
        [DataRow(3, 27)]
        [DataTestMethod]
        public void RowSumOddNumbers_Should_Return_Expected(long input, long expected)
        {
            // Arrange
            // see DataRow

            // Act
            var actual = SumOfOddNumbers.RowSumOddNumbers(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
