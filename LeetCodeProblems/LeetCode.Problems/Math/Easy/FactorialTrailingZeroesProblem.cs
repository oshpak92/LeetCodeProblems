using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 172. Factorial Trailing Zeroes
    /// https://leetcode.com/problems/factorial-trailing-zeroes/
    /// </summary>
    public class FactorialTrailingZeroesProblem
    {
        public int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
}
