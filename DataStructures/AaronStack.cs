using System;

namespace DataStructures
{
    public class AaronStack<T>
    {
        public StackNode Top { get; set; }
        public T Peek()
        {
            if (Top is null) throw new Exception();
            
            var pointer = Top;
            while (pointer.Next != null)
            {
                pointer = pointer.Next;
            }
            return pointer.Value;

        }

        public void Push(T value)
        {
            StackNode stackNode = new(value);
                
            if (IsEmpty())
            {
                Top = stackNode;
            }
            else
            {
                stackNode.Next = Top;
                Top = stackNode;
            }
            
        }

        public T Pop()
        {
            if (Top is null) throw new Exception();
            var pop = Top;
            Top = Top.Next;
            return pop.Value;
        }

        public bool IsEmpty()
        {
            return Top is null;
        }

        public class StackNode
        {
            public StackNode(T value)
            {
                Value = value;
                Next = null;
            }

            public T Value { get; set; }
            public StackNode Next { get; set; }
        }
    }
}