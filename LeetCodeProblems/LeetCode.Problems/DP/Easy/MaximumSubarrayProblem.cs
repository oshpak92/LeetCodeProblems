using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Easy
{
    /// <summary>
    /// 53. Maximum Subarray
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class MaximumSubarrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var sum = nums[i] + nums[i - 1];
                if (sum > nums[i])
                    nums[i] = sum;

                max = System.Math.Max(max, nums[i]);
            }

            return max;
        }
    }
}
