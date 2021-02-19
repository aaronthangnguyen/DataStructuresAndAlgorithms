using System;

namespace Algorithms
{
    public class BubbleSort
    {
        public static int[] Initialize(int[] array)
        {
            Console.WriteLine("Bubble Sort");
            // Declare variables
            var isSorted = false;
            var index = 0;
            var unsortedIndex = array.Length - 1;

            // Use while loop until isSorted = true
            while (isSorted == false)
            {
                if (unsortedIndex == 0)
                {
                    isSorted = true;
                }
                if (index == unsortedIndex)
                {
                    index = 0;
                    unsortedIndex = unsortedIndex - 1;
                }

                if (array[index] > array[index + 1])
                {
                    (array[index], array[index + 1]) = (array[index + 1], array[index]); // Swap
                }
                
                index = index + 1;
            }

            return array;
        }
    }
}