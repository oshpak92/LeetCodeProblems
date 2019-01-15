using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 66. Plus One
    /// https://leetcode.com/problems/plus-one/
    /// Runtime: 284 ms, faster than 88.60% of C# online submissions for Plus One.
    /// </summary>
    public class PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            bool overflow = false;
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                var newDigit = digits[i] + 1;
                if (newDigit / 10 == 0)
                {
                    digits[i] = newDigit;
                    break;
                }                    
                else
                {
                    digits[i] = newDigit % 10;
                    if (i == 0)
                        overflow = true; 
                }
            }

            if (overflow)
            {
                var bufer = new int[digits.Length + 1];
                bufer[0] = 1;
                return bufer;
            }

            return digits;
        }
    }
}
