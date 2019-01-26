using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 11. Container With Most Water
    /// https://leetcode.com/problems/container-with-most-water/
    /// Runtime: 128 ms, faster than 79.17% of C# online submissions for Container With Most Water.
    /// </summary>
    public class ContainerWithMostWaterProblem
    {
        public int MaxArea(int[] height)
        {
            if (height.Length < 2)
                return 0;

            var left = 0;
            var right = height.Length - 1;
            var container = 0;

            while(left < right)
            {
                container = System.Math.Max(container, System.Math.Min(height[left], height[right]) * (right-left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return container;
        }
    }
}
