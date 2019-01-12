using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 561. Array Partition I
    /// https://leetcode.com/problems/array-partition-i/
    /// </summary>
    public class ArrayPairSumProblem
    {
        public int ArrayPairSum(int[] nums)
        {
            if (nums.Length % 2 != 0)
                throw new ArgumentNullException(nameof(nums));

            Array.Sort(nums);
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += System.Math.Min(nums[i], nums[i+1]);
                i++;
            }

            return sum;
        }
    }
}
