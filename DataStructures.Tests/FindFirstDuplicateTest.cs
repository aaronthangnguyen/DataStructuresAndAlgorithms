using Xunit;

namespace DataStructures.Tests
{
    public class FindFirstDuplicateTest
    {
        [Fact]
        public void Test1()
        {
            //--- Arrange
            var array = new[] {"a", "b", "c", "d", "c", "e", "f"};

            //--- Act
            var actual = FindFirstDuplicate.Run(array);

            //--- Assert
            var expected = "c";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            //--- Arrange
            var array = new[] {"a", "b", "c", "d", "e", "e", "f"};

            //--- Act
            var actual = FindFirstDuplicate.Run(array);

            //--- Assert
            var expected = "e";
            Assert.Equal(expected, actual);
        }
    }
}