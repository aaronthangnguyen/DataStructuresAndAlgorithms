namespace Algorithms
{
    public class FindFirstX
    {
        public static int Run(string iString, int index = 0)
        {
            if (iString[index] == 'x') return index;

            return Run(iString, index + 1);
        }
    }
}