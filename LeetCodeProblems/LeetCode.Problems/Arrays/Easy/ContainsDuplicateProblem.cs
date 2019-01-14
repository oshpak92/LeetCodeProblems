using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 217. Contains Duplicate
    /// https://leetcode.com/problems/contains-duplicate/
    /// Runtime: 132 ms, faster than 85.59% of C# online submissions for Contains Duplicate.
    /// </summary>
    public class ContainsDuplicateProblem
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var buffer = new HashSet<int>();

            foreach (var item in nums)
            {
                if (buffer.Contains(item))
                {
                    return true;
                }
                else
                {
                    buffer.Add(item);
                }
            }

            return false;
        }
    }
}
