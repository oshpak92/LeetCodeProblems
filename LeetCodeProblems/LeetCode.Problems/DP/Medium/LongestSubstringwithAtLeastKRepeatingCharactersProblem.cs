using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Medium
{
    /// <summary>
    /// 395. Longest Substring with At Least K Repeating Characters
    /// https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters/
    /// </summary>
    public class LongestSubstringwithAtLeastKRepeatingCharactersProblem
    {
        public int LongestSubstring(string s, int k)
        {
            char[] str = s.ToCharArray();
            int[] counts = new int[26];
            int h, i, j, idx, max = 0, unique, noLessThanK;

            for (h = 1; h <= 26; h++)
            {
                counts = new int[26];
                i = 0;
                j = 0;
                unique = 0;
                noLessThanK = 0;
                while (j < str.Length)
                {
                    if (unique <= h)
                    {
                        idx = str[j] - 'a';
                        if (counts[idx] == 0)
                            unique++;
                        counts[idx]++;
                        if (counts[idx] == k)
                            noLessThanK++;
                        j++;
                    }
                    else
                    {
                        idx = str[i] - 'a';
                        if (counts[idx] == k)
                            noLessThanK--;
                        counts[idx]--;
                        if (counts[idx] == 0)
                            unique--;
                        i++;
                    }
                    if (unique == h && unique == noLessThanK)
                        max = System.Math.Max(j - i, max);
                }
            }

            return max;
        }
    }
}
