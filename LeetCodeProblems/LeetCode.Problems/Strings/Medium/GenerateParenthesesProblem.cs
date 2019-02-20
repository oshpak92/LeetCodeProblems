using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 22. Generate Parentheses
    /// https://leetcode.com/problems/generate-parentheses/
    /// Runtime: 284 ms, faster than 90.06% of C# online submissions for Generate Parentheses.
    /// Memory Usage: 31.3 MB, less than 16.39% of C# online submissions for Generate Parentheses.
    /// Solution from leetcode
    /// </summary>
    public class GenerateParenthesesProblem
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            backtrack(result, "", 0, 0, n);
            return result;
        }

        private void backtrack(IList<string> result, string current, int close, int open, int max)
        {
            if(current.Length == max * 2)
            {
                result.Add(current);
                return;
            }

            if (open < max)
                backtrack(result, current + "(", close, open + 1, max);
            if (close < open)
                backtrack(result, current + ")", close + 1, open, max);
        }
    }
}
