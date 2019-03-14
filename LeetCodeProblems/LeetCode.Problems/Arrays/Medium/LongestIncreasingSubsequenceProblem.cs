using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 300. Longest Increasing Subsequence
    /// https://leetcode.com/problems/longest-increasing-subsequence/
    /// Runtime: 112 ms, faster than 75.00% of C# online submissions for Longest Increasing Subsequence.
    /// Memory Usage: 21.7 MB, less than 60.00% of C# online submissions for Longest Increasing Subsequence.
    /// </summary>
    public class LongestIncreasingSubsequenceProblem
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            var counts = new int[nums.Length + 1];
            counts[counts.Length - 1] = 1;
            var max = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                counts[i] = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        counts[i] = System.Math.Max(counts[i], counts[j] + 1);
                    }
                }
                max = System.Math.Max(max, counts[i]);
            }

            return max;
        }
        //public int LengthOfLIS(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return 0;

        //    int maxLength = 1;

        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        var counter = 1;
        //        var tmp = nums[i];
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if(nums[j] > tmp)
        //            {
        //                counter++;
        //                tmp = nums[j];
        //            }
        //        }
        //        maxLength = System.Math.Max(maxLength, counter);
        //    }
        //    return maxLength;
        //}
    }
}
