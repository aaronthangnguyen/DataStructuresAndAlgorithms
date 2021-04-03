using System.Collections.Generic;

namespace DataStructures
{
    public class PriorityQueueSolution
    {
        public static int LastStoneWeight(int[] stones)
        {
            var priorityQueue = new PriorityQueue();
            foreach (var stone in stones)
            {
                priorityQueue.Enqueue(stone);
            }

            while (priorityQueue.Count > 1)
            {
                var firstStone = priorityQueue.Dequeue();
                var secondStone = priorityQueue.Dequeue();

                if (firstStone > secondStone)
                {
                    priorityQueue.Enqueue(firstStone - secondStone);
                }
            }

            return priorityQueue.Count > 0 ? priorityQueue.Dequeue() : 0;
        }
    }

    public class PriorityQueue
    {
        private List<int> _priorityQueue = new List<int>();

        public int Count => _priorityQueue.Count;

        public void Enqueue(int item)
        {
            _priorityQueue.Add(item);
            _priorityQueue.Sort();
            _priorityQueue.Reverse();
        }

        public int Dequeue()
        {
            var item = _priorityQueue[0];
            _priorityQueue.RemoveAt(0);
            return item;
        }
    }
}