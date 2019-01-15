using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 268. Missing Number
    /// https://leetcode.com/problems/missing-number/
    /// Runtime: 128 ms, faster than 98.08% of C# online submissions for Missing Number.
    /// </summary>
    public class MissingNumberProblem
    {
        public int MissingNumber(int[] nums)
        {
            if (nums.Length == 0)
                throw new ArgumentException(nameof(nums));

            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            var expectedSum = (double)nums.Length / 2 * (nums.Length + 1);
            return (int)expectedSum - sum;
        }
    }
}
