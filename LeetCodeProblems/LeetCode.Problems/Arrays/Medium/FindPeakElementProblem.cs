using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 162. Find Peak Element
    /// Runtime: 120 ms, faster than 27.50% of C# online submissions for Find Peak Element.
    /// https://leetcode.com/problems/find-peak-element/
    /// </summary>
    public class FindPeakElementProblem
    {
        public int FindPeakElement(int[] nums)
        {
            for (var i = 0; i< nums.Length; i++)
            {
                var next = i + 1 < nums.Length ? i + 1 : 0;
                var prev = i - 1 >= 0 ? i - 1 : nums.Length - 1; 
                if(nums[i] > nums[next] && nums[i] > nums[prev])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
