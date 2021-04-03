using Xunit;

namespace Algorithms.Test
{
    public class CountCharInStringArrayTest
    {
        [Fact]
        public void ShouldReturn10()
        {
            var stringArray = new []{"ab", "c", "def", "ghij"};

            var actual = CountCharInStringArray.CountChar(stringArray);
            var expected = 10;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ShouldReturn0IfNull()
        {
            var stringArray = new string[]{};

            var actual = CountCharInStringArray.CountChar(stringArray);
            var expected = 0;
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ShouldReturn0IfEmpty()
        {
            var stringArray = new string[]{""};

            var actual = CountCharInStringArray.CountChar(stringArray);
            var expected = 0;
            Assert.Equal(expected, actual);
        }
    }
}