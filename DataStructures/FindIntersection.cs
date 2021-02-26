using System.Collections.Generic;

namespace DataStructures
{
    public class FindIntersection
    {
        public static int[] Run(int[] firstArray, int[] secondArray)
        {
            var intersection = new List<int>();
            var firstDictionary = new Dictionary<int, bool>();

            foreach (var item in firstArray) firstDictionary.Add(item, true);

            foreach (var item in secondArray)
                if (firstDictionary.ContainsKey(item))
                    intersection.Add(item);

            return intersection.ToArray();
        }
    }
}