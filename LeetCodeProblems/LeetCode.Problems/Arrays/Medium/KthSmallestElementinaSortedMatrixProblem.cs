using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 378. Kth Smallest Element in a Sorted Matrix
    /// https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/
    /// </summary>
    public class KthSmallestElementinaSortedMatrixProblem
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var lo = matrix[0][0];
            var hi = matrix[matrix[0].Length - 1][matrix[0].Length - 1];
            
            while(lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                var count = 0;
                var j = matrix[0].Length - 1;

                for (int i = 0; i < matrix[0].Length; i++)
                {
                    while (j >= 0 && matrix[i][j] > mid) j--;
                    count += (j + 1);
                }
                if (count < k) lo = mid + 1;
                else hi = mid;
            }

            return lo;
        }
    }
}
