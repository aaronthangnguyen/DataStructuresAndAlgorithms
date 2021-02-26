using System.Collections.Generic;

namespace DataStructures
{
    public class FindMissingLetter
    {
        public static char Run(string sentence)
        {
            Dictionary<char, bool> dictionaryOfCharacter = new();

            foreach (var character in sentence) dictionaryOfCharacter.TryAdd(character, true);

            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (var character in alphabet)
                if (dictionaryOfCharacter.ContainsKey(character) is false)
                    return character;

            return ' ';
        }
    }
}