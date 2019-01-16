using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 88. Merge Sorted Array
    /// https://leetcode.com/problems/merge-sorted-array/
    /// Runtime: 296 ms, faster than 64.63% of C# online submissions for Merge Sorted Array.
    /// </summary>
    public class MergeSortedArrayProblem
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var p1 = m - 1;
            var p2 = n - 1;
            var lastIndex = m + n - 1;
            
            while (lastIndex >= 0 )
            {
                if(p2 < 0 || p1 >= 0 && nums1[p1] >= nums2[p2])
                {
                    nums1[lastIndex] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[lastIndex] = nums2[p2];
                    p2--;
                }
                lastIndex--;
            }
        }
    }
}
