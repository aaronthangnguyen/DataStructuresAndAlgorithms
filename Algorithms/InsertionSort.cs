namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] Run(int[] array)
        {
            // put an element in a bucket, starting at index 1
            // compare element with previous element, if bigger than shift it to the right
            // if not, break
            // put element in a bucket to a correct position

            for (var index = 1; index < array.Length; index++)
            {
                var bucket = array[index];
                var runningIndex = index - 1;

                while (runningIndex >= 0)
                {
                    if (array[runningIndex] > bucket)
                    {
                        array[runningIndex + 1] = array[runningIndex];
                        --runningIndex;
                    }
                    else
                    {
                        break;
                    }

                    array[runningIndex + 1] = bucket;
                }
            }

            return array;
        }
    }
}