using Xunit;

namespace DataStructures.Tests
{
    public class FindFirstNonDuplicatedLetterTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var word = "minimum";

            //--- Act
            var actual = FindFirstNonDuplicatedLetter.Run(word);

            //--- Assert
            var expected = 'n';
            Assert.Equal(expected, actual);
        }
    }
}