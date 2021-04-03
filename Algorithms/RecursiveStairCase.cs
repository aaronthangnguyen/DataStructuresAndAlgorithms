namespace Algorithms
{
    public class RecursiveStairCase
    {
        public static int CalculateNumberOfPaths(int number)
        {
            if (number < 0) return 0;
            if (number is 1 or 0) return 1;

            return CalculateNumberOfPaths(number - 1) +
                   CalculateNumberOfPaths(number - 2) +
                   CalculateNumberOfPaths(number - 3);
        }
    }
}