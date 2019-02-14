using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Easy
{
    /// <summary>
    /// 125. Valid Palindrome
    /// https://leetcode.com/problems/valid-palindrome/
    /// Runtime: 92 ms, faster than 95.38% of C# online submissions for Valid Palindrome.
    /// Memory Usage: 22 MB, less than 100.00% of C# online submissions for Valid Palindrome.
    /// </summary>
    public class ValidPalindromeProblem
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            var pl = 0;
            var pr = s.Length - 1;

            while(pl < pr)
            {
                if (!char.IsLetterOrDigit(s[pl])) { pl++; continue; }
                if (!char.IsLetterOrDigit(s[pr])) { pr--; continue; }

                if (char.ToLower(s[pl]) != char.ToLower(s[pr]))
                    return false;

                pl++; pr--;
            }

            return true;
        }
    }
}
