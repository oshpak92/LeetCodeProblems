using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Easy
{
    /// <summary>
    /// 628. Maximum Product of Three Numbers
    /// https://leetcode.com/problems/maximum-product-of-three-numbers/
    /// </summary>
    public class MaximumProductofThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            return System.Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3]);
        }

        //O(n)
        //public int MaximumProduct(int[] nums)
        //{
        //    var max = int.MinValue;
        //    var mem = new HashSet<int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i+1; j < nums.Length; j++)
        //        {
        //            if (j == i)
        //                continue;

        //            var product2 = nums[i] * nums[j];
        //            if (mem.Contains(product2))
        //                continue;
        //            else
        //                mem.Add(product2);

        //            for (int k =j +1; k < nums.Length; k++)
        //            {
        //                if (k == j || k == i)
        //                    continue;

        //                max = System.Math.Max(max, product2 * nums[k]);
        //            }
        //        }
        //    }

        //    return max;
        //}
    }
}
