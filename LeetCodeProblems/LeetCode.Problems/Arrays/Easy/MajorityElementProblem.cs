using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 169. Majority Element
    /// https://leetcode.com/problems/majority-element/
    /// Runtime: 136 ms, faster than 77.14% of C# online submissions for Majority Element.
    /// </summary>
    public class MajorityElementProblem
    {
        /// <summary>
        /// majority element must exis! othervise we have toi check is element majority or not
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement(int[] nums)
        {
            int count = 1;
            int maj_el = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[maj_el])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if(count == 0)
                {
                    maj_el = i;
                    count = 1;
                }
            }

            return nums[maj_el];
        }
    }
}
