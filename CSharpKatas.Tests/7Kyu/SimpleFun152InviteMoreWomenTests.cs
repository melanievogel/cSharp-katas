using CSharp_Katas._7Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests._7Kyu
{
    [TestClass]
    public class SimpleFun152InviteMoreWomenTests
    {
        [DataRow(new int[]{ 1, -1, 1 }, true)]
        [DataRow(new int[]{ 1, 1, 1 }, true)]
        [DataRow(new int[]{ -1, -1, -1 }, false)]
        [DataRow(new int[]{ 1, -1 }, false)]
        [DataTestMethod]
        public void InviteMoreWomen_Should_Return_Expected(int[] input, bool expected)
        {
            // Arrange
            // --> DataRows

            // Act
            var actual = SimpleFun152InviteMoreWomen.InviteMoreWomen(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
