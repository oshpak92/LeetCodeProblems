using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 326. Power of Three
    /// https://leetcode.com/problems/power-of-three/
    /// Runtime: 140 ms, faster than 95.45% of C# online submissions for Power of Three.
    /// </summary>
    public class PowerofThreeProblem
    {
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
                return false;

            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
