using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 34. Find First and Last Position of Element in Sorted Array
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// Runtime: 328 ms, faster than 15.79% of C# online submissions for Find First and Last Position of Element in Sorted Array.
    /// </summary>
    public class FindFirstandLastPositionofElementinSortedArrayProblem
    {

        public int[] SearchRange(int[] nums, int target)
        {
            int[] targetRange = { -1, -1 };
            var left = SearchTarget(nums, 0, nums.Length - 1, target, true);

            if (left == nums.Length || nums[left] != target)
            {
                return targetRange;
            }

            targetRange[0] = left;
            targetRange[1] = SearchTarget(nums, 0, nums.Length - 1, target, false) - 1;

            return targetRange;
        }

        public int SearchTarget(int[] nums, int left, int right, int target, bool leftSearch)
        {
            if (left == right)
                return left;

            var pivot = left + (right - left) / 2;

            if (nums[pivot] > target || (leftSearch && nums[pivot] == target))
                return SearchTarget(nums, left, pivot - 1, target, leftSearch);
            else
                return SearchTarget(nums, pivot + 1, right, target, leftSearch);
        }
    }
}
