namespace Algorithms
{
    public class CountCharInStringArray
    {
        public static int CountChar(string[] iArray)
        {
            if (iArray is null) return 0;
            
            var charCounter = 0;
            
            foreach (var item in iArray)
            {
                charCounter += CountChar(item);
            }

            return charCounter;
        }

        public static int CountChar(string iString)
        {
            if (iString.Length == 0) return 0;
            if (iString.Length == 1) return 1;
            
            return 1 + CountChar(iString.Substring(1, iString.Length - 1));
        }
    }
}