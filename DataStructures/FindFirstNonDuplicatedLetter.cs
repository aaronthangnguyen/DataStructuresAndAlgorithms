using System.Collections.Generic;

namespace DataStructures
{
    public class FindFirstNonDuplicatedLetter
    {
        public static char Run(string word)
        {
            Dictionary<char, int> characterFrequency = new();
            foreach (var character in word)
                if (characterFrequency.ContainsKey(character) is false)
                    characterFrequency.Add(character, 1);
                else
                    characterFrequency[character] += 1;

            foreach (var character in word)
                if (characterFrequency[character] == 1)
                    return character;

            return ' ';
        }
    }
}