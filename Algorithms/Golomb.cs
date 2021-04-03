using System.Collections.Generic;

namespace Algorithms
{
    public class Golomb
    {
        public static int Calculate(int number)
        {
            Dictionary<int, int> memo = new();
            return Calculate(number, memo);
        }

        public static int Calculate(int number, Dictionary<int, int> memo)
        {
            if (number is 1) return 1;
            
            if (memo.ContainsKey(number))
            {
                return memo[number];
            }
            else
            {
                var result = 1 + Calculate(number - Calculate( Calculate(number - 1,
                            memo),
                        memo),
                    memo);
                memo.Add(number, result);
                return memo[number];
            }
            

        }
    }
}