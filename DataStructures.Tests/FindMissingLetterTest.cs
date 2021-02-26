using Xunit;

namespace DataStructures.Tests
{
    public class FindMissingLetterTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var sentence = "the quick brown box jumps over a lazy dog";

            //--- Act

            var actual = FindMissingLetter.Run(sentence);

            //--- Assert
            var expected = 'f';
            Assert.Equal(expected, actual);
        }
    }
}