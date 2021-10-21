using CSharp_Katas._7Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests._7Kyu
{
    [TestClass]
    public class TwoToOneTests
    {
        [DataRow("ab", "abc", "abc")]
        [DataRow("abbb", "adbcd", "abcd")]
        [DataRow("aretheyhere", "yestheyarehere", "aehrsty")]
        [DataRow("loopingisfunbutdangerous", "lessdangerousthancoding", "abcdefghilnoprstu")]
        [DataRow("inmanylanguages", "theresapairoffunctions", "acefghilmnoprstuy")]
        [DataTestMethod]
        public void Longest_Should_Return_Expected(string s1, string s2, string expected)
        {
            // Arrange
            // --> see DataRows

            // Act
            var actual = TwoToOne.Longest(s1, s2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
