using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 55. Jump Game
    /// https://leetcode.com/problems/jump-game/submissions/
    /// Runtime: 128 ms, faster than 43.33% of C# online submissions for Jump Game.
    /// </summary>
    public class JumpGameProblem
    {
        public bool CanJump(int[] nums)
        {
            int lastPos = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;
        }


        //enum Index
        //{
        //    GOOD, BAD, UNKNOWN
        //}

        ////Dynamic Programming Bottom-up
        //public bool CanJump(int[] nums)
        //{
        //    Index[] memo = new Index[nums.Length];
        //    for (int i = 0; i < memo.Length; i++)
        //    {
        //        memo[i] = Index.UNKNOWN;
        //    }
        //    memo[memo.Length - 1] = Index.GOOD;

        //    for (int i = nums.Length - 2; i >= 0; i--)
        //    {
        //        int furthestJump = System.Math.Min(i + nums[i], nums.Length - 1);
        //        for (int j = i + 1; j <= furthestJump; j++)
        //        {
        //            if (memo[j] == Index.GOOD)
        //            {
        //                memo[i] = Index.GOOD;
        //                break;
        //            }
        //        }
        //    }

        //    return memo[0] == Index.GOOD;
        //}

        /// <summary>
        /// Approach 1 backtracking
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public bool CanJump(int[] nums)
        //{
        //    return CanJumpFromPosition(0, nums);
        //}

        //private bool CanJumpFromPosition(int position, int[] nums)
        //{
        //    if (position == nums.Length - 1)
        //        return true;

        //    var jump = System.Math.Min(position + nums[position], nums.Length-1);
        //    for(int next = jump; next > position; next--)
        //    {
        //        if(CanJumpFromPosition(next, nums))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
