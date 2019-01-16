using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// Runtime: 308 ms, faster than 64.58% of C# online submissions for Remove Duplicates from Sorted Array.
    /// </summary>
    public class RemoveDuplicatesfromSortedArrayProblem
    {
        /// <summary>
        /// Two pointers
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var i = 0;
            for(var j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }

        //public int RemoveDuplicates(int[] nums)
        //{
        //    if (nums.Length < 2)
        //        return nums.Length;

        //    var length = nums.Length;

        //    var start = 0;
        //    while(start != length - 1)
        //    {
        //        if(nums[start] == nums[start + 1])
        //        {
        //            var i = start + 1;
        //            var lastEl = nums[i];
        //            while(i < length-1)
        //            {
        //                nums[i] = nums[i + 1];
        //                i++;
        //            }
        //            nums[i] = lastEl;
        //            length--;
        //        }
        //        else
        //        {
        //            start++;
        //        }
        //    }
        //    return length;
        //}
    }
}
