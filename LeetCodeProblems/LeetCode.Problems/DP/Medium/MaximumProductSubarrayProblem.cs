using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Medium
{
    /// <summary>
    /// 152. Maximum Product Subarray
    /// https://leetcode.com/problems/maximum-product-subarray/
    /// </summary>
    public class MaximumProductSubarrayProblem
    {
        public int MaxProduct(int[] nums)
        {
            int prod = 1;
            int result = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                prod = prod * nums[i];
                result = System.Math.Max(prod, result);
                if (prod == 0)
                {
                    prod = 1;
                }
            }
            prod = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                prod = prod * nums[i];
                result = System.Math.Max(prod, result);
                if (prod == 0)
                {
                    prod = 1;
                }
            }
            return result;
        }
        //public int MaxProduct(int[] nums)
        //{
        //    var nums1 = new int[nums.Length];
        //    Array.Copy(nums, nums1, nums.Length);

        //    var max = nums[0];
        //    var max2 = nums[nums.Length - 1];

        //    int? lessZeroProduct = nums[0] < 0 ? (int?)nums[0] : null;
        //    nums1[0] = nums[0] == 0 ? 1 : nums[0];
        //    for (int i = 1; i < nums1.Length; i++)
        //    {
        //        var tmp = nums1[i - 1] < 0 ? 1: nums1[i - 1];
        //        if (nums1[i] == 0)
        //            lessZeroProduct = null;

        //        var product = nums1[i] * tmp;
        //        if(product < 0 && lessZeroProduct.HasValue)
        //        {
        //            product = lessZeroProduct.Value * product;
        //            lessZeroProduct = null;
        //        }
        //        else if (product < 0 && !lessZeroProduct.HasValue)
        //        {
        //            lessZeroProduct = product;
        //        }
        //        if (product > nums1[i])
        //        {
        //            nums1[i] = product;
        //        }
        //        max = System.Math.Max(max, nums1[i]);
        //    }
        //    lessZeroProduct = nums[nums.Length-1] < 0 ? (int?)nums[nums.Length - 1] : null;
        //    nums[nums.Length - 1] = nums[nums.Length - 1] == 0 ? 1 : nums[nums.Length - 1];
        //    for (int i = nums.Length - 2 ; i >= 0; i--)
        //    {
        //        var tmp = nums[i + 1] < 0 ? 1 : nums[i + 1];
        //        tmp = tmp == 0 ? 1 : tmp;
        //        if (nums[i] == 0)
        //        {
        //            lessZeroProduct = null;
        //        }

        //        var product = nums[i] * tmp;
        //        if (product < 0 && lessZeroProduct.HasValue)
        //        {
        //            product = lessZeroProduct.Value * product;
        //            lessZeroProduct = null;
        //        }
        //        else if (product < 0 && !lessZeroProduct.HasValue)
        //        {
        //            lessZeroProduct = product;
        //        }
        //        if (product > nums[i])
        //        {
        //            nums[i] = product;
        //        }
        //        max2 = System.Math.Max(max2, nums[i]);
        //    }

        //    return System.Math.Max( max, max2);
        //}
    }
}
