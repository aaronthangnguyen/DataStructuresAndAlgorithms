namespace Algorithms
{
    public class DoubleIntegersInArray
    {
        public static int[] Run(int[] iArray, int index = 0)
        {
            if (index == iArray.Length) return iArray;

            iArray[index] *= 2;
            
            return Run(iArray, index + 1);
        }
    }
}