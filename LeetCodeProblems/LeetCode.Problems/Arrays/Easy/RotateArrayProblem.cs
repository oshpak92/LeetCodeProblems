using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 189. Rotate Array
    /// https://leetcode.com/problems/rotate-array/
    /// Runtime: 296 ms, faster than 73.17% of C# online submissions for Rotate Array.
    /// </summary>
    public class RotateArrayProblem
    {
        public void Rotate(int[] nums, int k)
        {
            if (k == 0)
                return;
            if (nums.Length <= 1)
                return;

            k = k - (k / nums.Length) * nums.Length;

            var list = new List<int>();
            int someMagicPoint = nums.Length - k;
            var i = someMagicPoint;
            while(i < nums.Length)
            {
                list.Add(nums[i]);
                i++;
            }
            i = 0;
            while(i < someMagicPoint)
            {
                list.Add(nums[i]);
                i++;
            }
            for(i = 0; i< nums.Length; i++)
            {
                nums[i] = list[i];
            }
        }

        //    public void Rotate(int[] nums, int k)
        //    {
        //        if (k == 0)
        //            return;
        //        if (nums.Length <= 1)
        //            return;

        //        k = k - (k / nums.Length) * nums.Length;

        //        if (k == 0)
        //            return;

        //        var buf = nums[k];

        //        if (k * 2 == nums.Length)
        //            Swap(nums, k, 0);
        //        else
        //            Move(nums, k, buf, k, 1);
        //    }

        //    private void Move(int[] nums, int k, int val, int current, int i)
        //    {
        //        if (i > nums.Length) return;

        //        var next = current + k < nums.Length ? current + k : current + k -nums.Length; 
        //        var buf = nums[next];
        //        nums[next] = val;


        //        Debug.WriteLine(string.Join(',', nums));
        //        Move(nums, k, buf, next, i+1);
        //    }

        //    private void Swap(int[] nums, int k, int i)
        //    {
        //        if (i >= k) return;

        //        var tmp = nums[i + k];
        //        nums[i + k] = nums[i];
        //        nums[i] = tmp;
        //        Swap(nums, k, i + 1);
        //    }
    }
}
