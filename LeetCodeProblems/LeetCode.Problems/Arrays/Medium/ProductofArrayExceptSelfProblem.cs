using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 238. Product of Array Except Self
    /// https://leetcode.com/problems/product-of-array-except-self/
    /// Runtime: 320 ms, faster than 63.87% of C# online submissions for Product of Array Except Self.
    /// </summary>
    public class ProductofArrayExceptSelfProblem
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = 0; i < res.Length; i ++)
            {
                res[i] = 1;
            }
            int fromBegin = 1;
            int fromEnd = 1; 
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] *= fromBegin;
                fromBegin *= nums[i];
                res[nums.Length - 1 - i] *= fromEnd;
                fromEnd *= nums[nums.Length - 1 - i];               
            }
            return res;
        }
    }
}
