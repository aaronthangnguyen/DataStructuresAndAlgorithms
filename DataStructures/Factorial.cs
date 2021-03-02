namespace DataStructures
{
    public class Factorial
    {
        public static int CalculateFactorial(int number)
        {
            if (number is 1)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}