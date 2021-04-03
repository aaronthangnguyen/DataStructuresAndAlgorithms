using Xunit;

namespace Algorithms.Test
{
    public class DoubleIntegersInArrayTest
    {
        [Fact]
        public void ShouldReturnDoubledIntegersInArray()
        {
            var iArray = new[] {1, 2, 3, 4, 5};
                
            var actual = DoubleIntegersInArray.Run(iArray);
            var expected = new[] {2, 4, 6, 8, 10};
            Assert.Equal(expected, actual);
        }
    }
}