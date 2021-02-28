using Xunit;

namespace DataStructures.Tests
{
    public class ReverseStringTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var word = "abcde";

            //--- Act
            var actual = ReverseString.Run(word);

            //--- Assert
            var expected = "edcba";
            Assert.Equal(expected, actual);
        }
    }
}