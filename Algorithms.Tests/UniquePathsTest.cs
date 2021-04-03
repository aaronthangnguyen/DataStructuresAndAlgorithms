using Xunit;

namespace Algorithms.Test
{
    public class UniquePathsTest
    {
        [Fact]
        public void ShouldReturn28()
        {
            var actual = UniquePaths.Run(7, 3);
            var expected = 28;
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ShouldReturn6()
        {
            var actual = UniquePaths.Run(3, 3);
            var expected = 6;
            Assert.Equal(expected, actual);
        }
    }
}