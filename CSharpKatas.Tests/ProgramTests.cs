using CSharp_Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Katas_Tests
{
    [TestClass]
    public class ProgramTests
    {
        [DataRow("ab", "abc", "abc")]
        [DataRow("abbb", "adbcd", "abcd")]
        [DataRow("aretheyhere", "yestheyarehere", "aehrsty")]
        [DataRow("loopingisfunbutdangerous", "lessdangerousthancoding", "abcdefghilnoprstu")]
        [DataRow("inmanylanguages", "theresapairoffunctions", "acefghilmnoprstuy")]
        [DataTestMethod]
        public void Longest_Should_Return_Expected(string s1, string s2, string expected)
        {
            //Act
            var actual = Program.Longest(s1, s2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
