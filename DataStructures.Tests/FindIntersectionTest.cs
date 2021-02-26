using Xunit;

namespace DataStructures.Tests
{
    public class FindIntersectionTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var firstArray = new[] {1, 2, 3, 4, 5};
            var secondArray = new[] {0, 2, 4, 6, 8};

            //--- Act
            var actual = FindIntersection.Run(firstArray, secondArray);


            //--- Assert
            var expected = new[] {2, 4};
            Assert.Equal(expected, actual);
        }
    }
}