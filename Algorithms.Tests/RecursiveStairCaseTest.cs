using Xunit;

namespace Algorithms.Test
{
    public class RecursiveStairCaseTest
    {
        [Fact]
        public void ShouldReturn1()
        {
            var actual = RecursiveStairCase.CalculateNumberOfPaths(0);
            var expected = 1;
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ShouldReturn2()
        {
            var actual = RecursiveStairCase.CalculateNumberOfPaths(2);
            var expected = 2;
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void ShouldReturn4()
        {
            var actual = RecursiveStairCase.CalculateNumberOfPaths(3);
            var expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}