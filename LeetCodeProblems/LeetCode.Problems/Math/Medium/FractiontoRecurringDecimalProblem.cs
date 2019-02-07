using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 166. Fraction to Recurring Decimal
    /// https://leetcode.com/problems/fraction-to-recurring-decimal/
    /// Runtime: 96 ms, faster than 92.22% of C# online submissions for Fraction to Recurring Decimal.
    /// Memory Usage: 7.8 MB, less than 35.29% of C# online submissions for Fraction to Recurring Decimal.
    /// </summary>
    public class FractiontoRecurringDecimalProblem
    {
        public string FractionToDecimal(int num, int denom)
        {
            var str = new StringBuilder();
            var map = new Dictionary<long, int>();
            long numerator = num;
            long denominator = denom;

            var sign = num != 0 ? ((numerator < 0 && denominator > 0) || (numerator > 0 && denominator < 0) ? "-" : "") : ""; 
            numerator = System.Math.Abs(numerator);
            denominator = System.Math.Abs(denominator);

            var firstPart = numerator / denominator;
            var diff = numerator % denominator;
            str.Append(sign);
            str.Append(firstPart);

            if (diff == 0)
                return str.ToString();

            str.Append(".");
            do
            {
                var tmp = diff * 10;
                var newDigit = tmp / denominator;
                diff = tmp - newDigit * denominator;

                if (map.ContainsKey(diff))
                {
                    if (str[map[diff]].ToString() != newDigit.ToString())
                    {
                        str.Append(newDigit);
                        map[diff]++;
                    }
                    str.Insert(map[diff], "(");
                    str.Append(")");
                    break;
                }
                else
                {
                    str.Append(newDigit);
                    map.Add(diff, str.Length - 1);
                }
            }
            while (diff != 0);

            return str.ToString();
        }
    }
}
