using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 8. String to Integer (atoi)
    /// https://leetcode.com/problems/string-to-integer-atoi/
    /// Runtime: 96 ms, faster than 74.86% of C# online submissions for String to Integer (atoi).
    /// Memory Usage: 10.2 MB, less than 49.76% of C# online submissions for String to Integer (atoi).
    /// </summary>
    public class StringtoIntegerAtoiProblem
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;
            str = str.Trim(' ');

            if (!char.IsDigit(str[0]) && (str[0] != '+' && str[0] != '-'))
                return 0;

            var sign = str[0] == '-' ? -1 : 1;

            var i = char.IsDigit(str[0]) ? 0 : 1;

            while (i < str.Length && str[i] - 48 == 0)
                i++;

            if (i >= str.Length)
                return 0;

            var result = 0;
            while (i < str.Length && char.IsDigit(str[i]))
            {
                var val = str[i] - 48;

                if (sign > 0 && (int.MaxValue / 10 < result || (result == int.MaxValue / 10) && val > 7)) return int.MaxValue;
                if (sign < 0 && (int.MinValue / -10 < result || (result == int.MinValue / -10) && val > 8)) return int.MinValue;

                result = result * 10 + val;
                i++;
            }

            return result * sign;
        }
    }
}
