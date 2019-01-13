using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 287. Find the Duplicate Number
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// Runtime: 116 ms, faster than 72.97% of C# online submissions for Find the Duplicate Number.
    /// </summary>
    public class FindtheDuplicateNumberProblem
    {
        public int FindDuplicate(int[] nums)
        {
            var hare = nums[0];
            var tortoize = nums[0];

            do
            {
                tortoize = nums[tortoize];
                hare = nums[nums[hare]];
            }
            while (hare != tortoize);

            var ptr1 = nums[0];
            var ptr2 = tortoize;

            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;
        }


        //        Note:
        //You must not modify the array(assume the array is read only). - this one is not included
        //You must use only constant, O(1) extra space.
        //Your runtime complexity should be less than O(n2).
        //There is only one duplicate number in the array, but it could be repeated more than once.
        //public int FindDuplicate(int[] nums)
        //{
        //    Array.Sort(nums);
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == nums[i + 1])
        //            return nums[i];
        //    }
        //    return -1;
        //}
    }
}
