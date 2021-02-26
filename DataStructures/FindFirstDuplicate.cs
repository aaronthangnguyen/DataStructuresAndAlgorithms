using System.Collections.Generic;

namespace DataStructures
{
    public class FindFirstDuplicate
    {
        public static string Run(string[] arrayOfString)
        {
            // Create a Dictionary
            Dictionary<string, bool> dictionaryOfString = new();

            // Iterate over arrayString
            foreach (var item in arrayOfString)
                if (dictionaryOfString.ContainsKey(item) is false)
                    dictionaryOfString.Add(item, true);
                else
                    return item;

            return "";

            // If Dictionary not contains key, create new

            // If Dictionary contains key, return key -> duplicated value
        }
    }
}