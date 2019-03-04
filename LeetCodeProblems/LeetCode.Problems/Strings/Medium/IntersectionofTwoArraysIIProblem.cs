using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Strings.Medium
{
    /// <summary>
    /// 350. Intersection of Two Arrays II
    /// https://leetcode.com/problems/intersection-of-two-arrays-ii/
    /// 100 %
    /// </summary>
    public class IntersectionofTwoArraysIIProblem
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var nums1Map = new Dictionary<int, int>();
            var nums2Map = new Dictionary<int, int>();
            var result = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1Map.ContainsKey(nums1[i]))
                    nums1Map[nums1[i]] += 1;
                else
                    nums1Map[nums1[i]] = 1;
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2Map.ContainsKey(nums2[i]))
                    nums2Map[nums2[i]] += 1;
                else
                    nums2Map[nums2[i]] = 1;
            }

            foreach (var item in nums1Map)
            {
                if (nums2Map.ContainsKey(item.Key))
                {
                    int count = System.Math.Min(nums2Map[item.Key], item.Value);
                    while (count > 0)
                    {
                        result.Add(item.Key);
                        count--;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
