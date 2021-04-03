using Xunit;

namespace DataStructures.Tests
{
    public class PriorityQueueTest
    {
        [Fact]
        public void Test1()
        {
            var stones = new[] {2, 7, 4, 1, 8, 1};
            var actual = PriorityQueueSolution.LastStoneWeight(stones);

            var expected = 1;
            Assert.Equal(expected, actual);
        }
    }
}