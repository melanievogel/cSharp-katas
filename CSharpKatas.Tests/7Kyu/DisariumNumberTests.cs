using CSharp_Katas._7Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests._7Kyu
{
    [TestClass]
    public class DisariumNumberTests
    {
        [DataRow(89, "Disarium !!")]
        [DataRow(564, "Not !!")]
        [DataRow(1024, "Not !!")]
        [DataRow(135, "Disarium !!")]
        [DataTestMethod]
        public void DisariumNumbers_Should_Return_Expected(int input, string expected)
        {
            // Arrange
            // --> DataRow

            // Act
            var actual = DisariumNumber.DisariumNumbers(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
