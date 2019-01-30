using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 69. Sqrt(x)
    /// https://leetcode.com/problems/sqrtx/
    /// Runtime: 48 ms, faster than 100.00% of C# online submissions for Sqrt(x).
    /// </summary>
    public class SqrtxProblem
    {
        /// <summary>
        /// Binary search approach
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            if (x <= 0)
                return 0;

            var left = 1;
            var right = x;

            while (true)
            {
                //find middle value
                var mid = left + (right - left) / 2;
                
                if(mid > x / mid)
                {
                    right = mid - 1;    
                }
                else
                {
                    if (mid + 1 > x / (mid + 1))
                        return mid;
                    else
                        left = mid + 1;
                }
            }
        }
    }
}
