using Xunit;

namespace Algorithms.Test
{
    public class FindFirstXTest
    {
        [Fact]
        public void ShouldReturn23()
        {
            var iString = "abcdefghijklmnopqrstuvwxyz";

            var actual = FindFirstX.Run(iString);
            var expected = 23;
            Assert.Equal(expected, actual);
        }
    }
}