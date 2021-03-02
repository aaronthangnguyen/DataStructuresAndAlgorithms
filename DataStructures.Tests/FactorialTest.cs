using Xunit;

namespace DataStructures.Tests
{
    public class FactorialTest
    {
        [Fact]
        public void CalculateFactorialTest()
        {
            //--- Act
            var actual = Factorial.CalculateFactorial(5);
            
            //--- Assert
            var expected = 120;
            Assert.Equal(expected, actual);
        }
    }
}