namespace DataStructures
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }

    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Prepend(int data)
        {
            if (Head == null)
            {
                var node = new Node(data);
                Head = node;
            }
            else
            {
                var node = new Node(data);
                node.Next = Head;
                Head = node;
            }
        }

        public void Append(int data)
        {
            if (Head == null)
            {
                var node = new Node(data);
                Head = node;
            }
            else
            {
                var node = Head;

                while (node.Next != null) node = node.Next;

                var newNode = new Node(data);
                newNode.Next = null;
                node.Next = newNode;
            }
        }

        public Node RetrieveByIndex(int index)
        {
            var node = Head;

            for (var i = 0; i < index; i++) node = node.Next;

            return node;
        }

        public void DeleteByIndex(LinkedList linkedList
            , int index)
        {
            if (index == 0)
            {
                Head = linkedList.RetrieveByIndex(1);
            }
            else
            {
                var previousNode = linkedList.RetrieveByIndex(index - 1);
                var nextNode = linkedList.RetrieveByIndex(index + 1);
                previousNode.Next = nextNode;
            }
        }
    }
}