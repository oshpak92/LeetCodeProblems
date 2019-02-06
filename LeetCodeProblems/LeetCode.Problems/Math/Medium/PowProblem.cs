using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 50. Pow(x, n)
    /// https://leetcode.com/problems/powx-n/submissions/
    /// Runtime: 4196 ms, faster than 0.80% of C# online submissions for Pow(x, n).
    /// </summary>
    public class PowProblem
    {
        public double MyPow(double x, int n)
        {
            //try to use binary search here
            if (n == 0)
                return 1;
            if (x == 1)
                return 1;
            if (x == 0)
                return 0;

            var result = x;
            long pow = 1;
            long nlong = System.Math.Abs((long)n);

            while (pow != nlong && result != 0)
            {
                if(pow * 2 <= nlong)
                {
                    result *= result;
                    pow *= 2;
                }
                else
                {
                    result *= x;
                    pow++;
                }
                if (pow == int.MaxValue - 1)
                {

                }
            }

            return n > 0 ? result: 1.0/result;
        }
    }
}
