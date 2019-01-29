using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 13. Roman to Integer
    /// https://leetcode.com/problems/roman-to-integer/
    /// Runtime: 124 ms, faster than 49.46% of C# online submissions for Roman to Integer.
    /// </summary>
    public class RomantoIntegerProblem
    {
        private readonly Dictionary<char, int> numbersMap = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

        private readonly Dictionary<string, int> specialCasesMap = new Dictionary<string, int>()
            {
                { "IV", 4},
                { "IX", 9},
                { "XL", 40},
                { "XC", 90},
                { "CD", 400},
                { "CM", 900}
            };

        public int RomanToInt(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int value;
                if(i + 1 < s.Length  && specialCasesMap.TryGetValue(s.Substring(i, 2), out value))
                {
                    sum += value;
                    i++;
                }
                else if (numbersMap.TryGetValue(s[i], out value))
                {
                    sum += value;
                }
            }

            return sum;
        }
    }
}
