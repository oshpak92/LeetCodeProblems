using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 33. Search in Rotated Sorted Array
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class SearchinRotatedSortedArrayProblem
    {
        public int Search(int[] nums, int target)
        {
            var size = nums.Length;
            if (size == 0 || target > nums[size - 1] && target < nums[0])
                return -1;//does not exists


            //search pivot
            var pivot = searchPivot(nums, 0, nums.Length - 1);

            if (target > nums[pivot])
                return -1;


            if (target <= nums[pivot] && target >= nums[0] || pivot == size - 1)
            {
                //located from the left side of pivot
                return searchTarget(nums, target, 0, pivot);
            }
            else
            {
                //from the right side of the pivot position
                return searchTarget(nums, target, pivot + 1, size - 1);
            }
        }

        public int searchTarget(int[] nums, int target, int leftPointer, int rightPointer)
        {
            if (nums[leftPointer] == target)
                return leftPointer;

            if (leftPointer == rightPointer)
                return -1;

            var step = (rightPointer - leftPointer) / 2;
            if (step == 0)
            {
                return nums[rightPointer] == target ? rightPointer : -1;
            }

            var pivot = leftPointer + step + (rightPointer - leftPointer) % 2;
            if (target < nums[pivot])//move left
            {
                rightPointer = pivot;
            }
            else
            {
                leftPointer = pivot;
            }

            return searchTarget(nums, target, leftPointer, rightPointer);
        }

        public int searchPivot(int[] nums, int left, int right)
        {
            if (right - left == 1)
                return nums[left] > nums[right] ? left : right;

            var pivot = left + (right - left) / 2 + (right - left) % 2;

            if (pivot == 0)
                return 0;

            if (pivot + 1 < nums.Length && nums[pivot] > nums[pivot + 1])
                return pivot;
            else if (pivot - 1 >= 0 && nums[pivot - 1] > nums[pivot])
                return pivot - 1;

            if (nums[0] > nums[pivot])
                right = pivot;
            else
                left = pivot;

            return searchPivot(nums, left, right);
        }


        //public int searchPivot(int [] nums, int pivot, int oldPivot)
        //{
        //    if (pivot + 1 == nums.Length)
        //        return pivot;

        //    if (nums[pivot] > nums[pivot + 1])
        //        return pivot;

        //    var cachedPivot = pivot;
        //    if (nums[0] > nums[pivot])
        //    {
        //        //move right
        //        pivot = oldPivot + (pivot - oldPivot) / 2;
        //    }
        //    else
        //    {
        //        //move left
        //        pivot = pivot + (nums.Length - pivot) / 2;
        //    }

        //    return searchPivot(nums, pivot, cachedPivot);
        //}
    }
}
