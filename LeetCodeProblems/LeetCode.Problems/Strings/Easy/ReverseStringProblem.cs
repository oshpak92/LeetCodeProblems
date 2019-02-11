using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings
{
    /// <summary>
    /// 344. Reverse String
    /// https://leetcode.com/problems/reverse-string/
    /// Runtime: 440 ms, faster than 33.62% of C# online submissions for Reverse String.
    /// Memory Usage: 21.5 MB, less than 0.97% of C# online submissions for Reverse String.
    /// </summary>
    public class ReverseStringProblem
    {
        public void ReverseString(char[] s)
        {
            if (s.Length <= 1)
                return;

            var length = s.Length;
            var i = 0;
            while (i <= length - 1 - i)
            {
                var tmp = s[i];
                s[i] = s[length - 1 - i];
                s[length - 1 - i] = tmp;
                i++;
            }
        }
    }
}
