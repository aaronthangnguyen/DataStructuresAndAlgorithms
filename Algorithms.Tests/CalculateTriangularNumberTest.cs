using Xunit;

namespace Algorithms.Test
{
    public class CalculateTriangularNumberTest
    {
        [Fact]
        public void ShouldReturn28()
        {
            var actual = CalculateTriangularNumber.Run(7);
            var expected = 28;
            Assert.Equal(expected, actual);
        }
    }
}