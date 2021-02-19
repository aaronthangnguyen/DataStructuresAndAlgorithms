using Xunit;
using Xunit.Abstractions;

namespace DataStructures.Test
{
    public class LinkedListTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public LinkedListTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void PrependAnEmptyLinkedListShouldReturnHead()
        {
            var linkedList = new LinkedList();
            linkedList.Prepend(1);

            var node = linkedList.Head;
            while (node != null) // node.Next != null doesn't get the last node
            {
                _testOutputHelper.WriteLine($"{node.Data}");
                node = node.Next;
            }
        }

        [Fact]
        public void PrependShouldAddAtTheBeginning()
        {
            var linkedList = new LinkedList();
            linkedList.Prepend(1);
            linkedList.Prepend(3);
            linkedList.Prepend(5);

            var node = linkedList.Head;
            while (node != null) // node.Next != null doesn't get the last node
            {
                _testOutputHelper.WriteLine($"{node.Data}");
                node = node.Next;
            }
        }
        
        [Fact]
        public void AppendShouldAddAtTheEnd()
        {
            var linkedList = new LinkedList();
            linkedList.Prepend(1);
            linkedList.Append(3);
            linkedList.Append(5);

            var node = linkedList.Head;
            while (node != null) // node.Next != null doesn't get the last node
            {
                _testOutputHelper.WriteLine($"{node.Data}");
                node = node.Next;
            }
        }

        [Fact]
        public void RetrieveShouldWork()
        {
            var linkedList = new LinkedList();
            linkedList.Prepend(1);
            linkedList.Prepend(3);
            linkedList.Prepend(5);
            linkedList.Prepend(7);
            
            var actual = linkedList.RetrieveByIndex(2);

            var expected = linkedList.Head.Next.Next;
            
            Assert.Equal(expected.Data, actual.Data);


        }
        
        [Fact]
        public void DeleteShouldWork()
        {
            var linkedList = new LinkedList();
            linkedList.Prepend(1);
            linkedList.Prepend(3);
            linkedList.Prepend(5);
            linkedList.Prepend(7);
            
            // 7-5-3-1 -> 7-3-1
            // linkedList.Head.Next.Next = linkedList.Head.Next.Next.Next;

            linkedList.DeleteByIndex(linkedList,0);
            
            var runNode = linkedList.Head;
            while (runNode != null) // node.Next != null doesn't get the last node
            {
                _testOutputHelper.WriteLine($"{runNode.Data}");
                runNode = runNode.Next;
            }
            
        }
    }
}