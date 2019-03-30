using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 15. 3Sum
    /// https://leetcode.com/problems/3sum/
    /// Runtime: 304 ms, faster than 98.94% of C# online submissions for 3Sum.
    /// Memory Usage: 34.5 MB, less than 73.58% of C# online submissions for 3Sum.
    /// </summary>
    public class ThreeSumProblem
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 3)
                return result;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length-2; i++)
            {
                if(i == 0 || i > 0 && (nums[i] != nums[i - 1]))
                {
                    int lo = i+1, hi = nums.Length-1, sum = 0 - nums[i];
                    while(lo < hi)
                    {
                        if (nums[lo] + nums[hi] == sum)
                        {
                            result.Add(new List<int>() { nums[i], nums[lo], nums[hi] });
                            while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                            while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                            lo++; hi--;
                        }
                        else if (nums[lo] + nums[hi] < sum)
                            lo++;
                        else
                            hi--;
                    } 
                }
            }

            return result;
        }
    }
}
