using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 3. Longest Substring Without Repeating Characters
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// 
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharactersProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var lettersMap = new Dictionary<char, int>();
            var maxLength = 0;
            var pointer = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var nextLength = i + 1 - pointer;
                if (lettersMap.TryAdd(s[i], i))
                {
                    maxLength = System.Math.Max(maxLength, nextLength);
                }
                else
                {
                    if (pointer > lettersMap[s[i]])
                        maxLength = System.Math.Max(maxLength, nextLength);
                    else
                        pointer = lettersMap[s[i]] + 1;

                    lettersMap[s[i]] = i;
                }
            }

            return maxLength;
        }
    }
}
