using System.Collections.Generic;

namespace Algorithms
{
    public class UniquePaths
    {
        public static int Run(int rows, int columns)
        {
            Dictionary<string,int> memo = new();
            return Run(rows, columns, memo);
        }
        
        public static int Run(int rows, int columns, Dictionary<string,int> memo)
        {
            if (rows < 1 || columns < 1) return 0;
            if (rows == 1 || columns == 1) return 1;

            if (!memo.ContainsKey($"r{rows}c{columns}"))
            {
                memo.Add($"r{rows}c{columns}",
                    Run(rows - 1, columns, memo) +
                    Run(rows, columns - 1, memo));
              
            }
            
            return memo[$"r{rows}c{columns}"];
        }
    }
}