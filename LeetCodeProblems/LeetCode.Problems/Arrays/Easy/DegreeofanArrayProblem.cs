using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 697. Degree of an Array
    /// https://leetcode.com/problems/degree-of-an-array/
    /// </summary>
    public class DegreeofanArrayProblem
    {
        public int FindShortestSubArray(int[] nums)
        {
            var memory = new Dictionary<int, int[]>();
            var maxCount = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (memory.ContainsKey(nums[i]))
                {
                    memory[nums[i]][0]++;
                    memory[nums[i]][2] = i;
                    maxCount = System.Math.Max(maxCount, memory[nums[i]][0]);
                }
                else
                {
                    //{count, firstIndex, lastIndex}
                    memory[nums[i]] = new int[3] { 1, i, i };
                }
            }

            var minLength = int.MaxValue;
            foreach (var item in memory)
            {
                if (item.Value[0] == maxCount)
                {
                    minLength = System.Math.Min(minLength, (item.Value[2] - item.Value[1]) + 1);
                }
            }

            return minLength == 0 ? 1 : minLength;
        }
    }
}
