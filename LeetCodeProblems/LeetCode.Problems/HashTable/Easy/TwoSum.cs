using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.HashTable.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dictionary[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement) && dictionary[complement] != i)
                {
                    return new int[] { i, dictionary[complement] };
                }
            }

            return new int[] { };
        }
    }
}
