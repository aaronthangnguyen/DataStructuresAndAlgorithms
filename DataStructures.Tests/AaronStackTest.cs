using Xunit;

namespace DataStructures.Tests
{
    public class AaronStackTest
    {
        public AaronStack<int> @AaronStack = new();
        public AaronStackTest()
        {
            @AaronStack.Push(5);
            @AaronStack.Push(4);
            @AaronStack.Push(3);
            @AaronStack.Push(2);
            @AaronStack.Push(1);
            @AaronStack.Push(0);
        }

        [Fact]
        public void ShouldNotBeEmpty()
        {
            var actual = AaronStack.IsEmpty();
            var expected = false;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldPeek()
        {
            var actual = AaronStack.Peek();
            var expected = 5;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldPop()
        {
            var actual = AaronStack.Pop();
            var expected = 0;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldPush()
        {
            AaronStack.Push(-1);

            var actual = AaronStack.Top.Value;
            var expected = -1;
            Assert.Equal(expected, actual);
        }
    }
    
}