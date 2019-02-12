using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Easy
{
    /// <summary>
    /// 14. Longest Common Prefix
    /// https://leetcode.com/problems/longest-common-prefix/
    /// Runtime: 128 ms, faster than 52.77% of C# online submissions for Longest Common Prefix.
    /// Memory Usage: 22.3 MB, less than 0.99% of C# online submissions for Longest Common Prefix.
    /// </summary>
    public class LongestCommonPrefixProblem
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;
            if (strs.Length == 1)
                return strs[0];

            var prefix = new StringBuilder();
            var pointer = 0;

            while (true)
            {
                var currentCharacter = char.MinValue;
                for(int i = 0; i < strs.Length; i++)
                {
                    if (strs[i] == null || pointer >= strs[i].Length)
                        return prefix.ToString();

                    if (i == 0)
                        currentCharacter = strs[i][pointer];

                    if (currentCharacter != strs[i][pointer])
                        return prefix.ToString(); //exit
                }

                prefix.Append(currentCharacter);
                pointer++;
            }
        }
    }
}
