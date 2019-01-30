using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 202. Happy Number
    /// https://leetcode.com/problems/happy-number/
    /// Runtime: 48 ms, faster than 87.10% of C# online submissions for Happy Number.
    /// </summary>
    public class HappyNumberProblem
    {
        public bool IsHappy(int n)
        {
            var hash = new HashSet<int>();
            var next = n;
            while(!hash.Contains(next))
            {
                var sum = 0;
                hash.Add(next);
                while(next != 0)
                {
                    sum += (next % 10) * (next % 10);
                    next /= 10;
                }
                if (sum == 1)
                    return true;

                next = sum;
            }
            return false;
        }
    }
}
