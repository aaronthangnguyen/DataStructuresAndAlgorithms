using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ReverseString
    {
        public static string Run(string word)
        {
            Stack<char> characterStack = new();

            foreach (var character in word)
            {
                characterStack.Push(character);
            }

            StringBuilder reversedWord = new();

            while (characterStack.Count > 0)
            {
                reversedWord.Append(characterStack.Pop());
            }

            return reversedWord.ToString();
        }
    }
}