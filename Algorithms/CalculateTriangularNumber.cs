namespace Algorithms
{
    public class CalculateTriangularNumber
    {
        public static int Run(int position)
        {
            if (position == 1) return 1;

            return position + Run(position - 1);
        }
    }
}