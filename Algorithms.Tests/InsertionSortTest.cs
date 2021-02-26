using Xunit;

namespace Algorithms.Test
{
    public class InsertionSortTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var array = new[] {4, 2, 7, 1, 3};

            //--- Act
            var actual = InsertionSort.Run(array);

            //--- Assert
            var expected = new[] {1, 2, 3, 4, 7};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            //--- Arrange
            var array = new[] {9, 7, 5, 1, 2, 6, 8, 0, 4, 3};

            //--- Act
            var actual = InsertionSort.Run(array);

            //--- Assert
            var expected = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Assert.Equal(expected, actual);
        }
    }
}