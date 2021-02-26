using Xunit;

namespace Algorithms.Test
{
    public class BubbleSortTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var array = new[] {3, 1, 2, 4, 0};

            //--- Act
            var actual = BubbleSort.Initialize(array);

            //--- Assert
            var expected = new[] {0, 1, 2, 3, 4};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            //--- Arrange
            var array = new[] {1, 0, 0, 0, 0};

            //--- Act
            var actual = BubbleSort.Initialize(array);

            //--- Assert
            var expected = new[] {0, 0, 0, 0, 1};
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            //--- Arrange
            var array = new[] {10, -1, -3, -5, -99};

            //--- Act
            var actual = BubbleSort.Initialize(array);

            //--- Assert
            var expected = new[] {-99, -5, -3, -1, 10};
            Assert.Equal(expected, actual);
        }
    }
}