using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Easy
{
    /// <summary>
    /// 198. House Robber
    /// https://leetcode.com/problems/house-robber/submissions/
    /// </summary>
    public class HouseRobberProblem
    {
        //public int Rob(int[] nums)
        //{
        //    if (nums.Length == 1)
        //        return nums[0];
        //    else if (nums.Length == 0)
        //        return 0;

        //    var max = System.Math.Max(nums[0], nums[1]);
        //    for (int i = 2; i < nums.Length; i++)
        //    {
        //        var curentMax = nums[i - 2] + nums[i];
        //        if (curentMax >= max)
        //            nums[i] = curentMax;
        //        else
        //            nums[i] = max - nums[i];

        //        max = System.Math.Max(max, nums[i]);
        //    }

        //    return max;
        //}

        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 0)
                return 0;

            var memo = new int[nums.Length];
            for (int i = 0; i < memo.Length; i++)
                memo[i] = -1;
            

            return rob(nums, memo, nums.Length - 1);
        }

        private int rob(int[] nums, int[] memo, int i)
        {
            if (i < 0)
            {
                return 0;
            }
            if (memo[i] >= 0)
                return memo[i];
            
            var max = System.Math.Max(rob(nums, memo, i - 2) + nums[i], rob(nums, memo, i - 1));
            memo[i] = max;
            return max;
        }
    }
}
