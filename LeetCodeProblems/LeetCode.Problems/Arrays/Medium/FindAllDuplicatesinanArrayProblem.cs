using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 442. Find All Duplicates in an Array
    /// https://leetcode.com/problems/find-all-duplicates-in-an-array
    /// Runtime: 376 ms, faster than 92.11% of C# online submissions for Find All Duplicates in an Array.
    /// </summary>
    public class FindAllDuplicatesinanArrayProblem
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var resultSet = new HashSet<int>();

            for(int i = 0; i < nums.Length; i ++)
            {
                var index = System.Math.Abs(nums[i]) - 1;
                if(nums[index] < 0)
                {
                    resultSet.Add(System.Math.Abs(nums[i]));
                }
                else
                {
                    nums[index] *= -1;
                }
            }

            return resultSet.ToList();
        }
    }
}
