using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 75. Sort Colors
    /// https://leetcode.com/problems/sort-colors/
    /// </summary>
    public class SortColorsProblems
    {
        public void SortColors(int[] nums)
        {
            int index0 = -1, index1 = -1, index2 = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                    index2 = index2 != -1 ? index2 + 1 : index1 != -1 ? index1 + 1 : index0 != -1 ? index0 + 1 : 0;
                else if (nums[i] == 1)
                {
                    index2 = index2 == -1 ? -1 : index2 + 1;
                    index1 = index1 != -1 ? index1 + 1 : index0 != -1 ? index0 + 1 : 0;
                    nums[index1] = 1;
                    if (index2 != -1) nums[index2] = 2;
                }
                else if (nums[i] == 0)
                {
                    index2 = index2 == -1 ? -1 : index2 + 1;
                    index1 = index1 != -1 ? index1 + 1 : -1;
                    nums[++index0] = 0;
                    if (index1 != -1) nums[index1] = 1;
                    if (index2 != -1) nums[index2] = 2;
                }
            }
        }

        //public void SortColors(int[] nums)
        //{
        //    if (nums.Length <= 1)
        //        return;

        //    int p1 = -1, p2 = nums.Length;
        //    var oneExists = false;

        //    while (p2 - 1 >= 0 && nums[p2-1] == 2)
        //    {
        //        p2--;
        //    }
        //    while (p1 + 1 < nums.Length && nums[p1 + 1] == 0)
        //    {
        //        p1++;
        //    }

        //    for (int i = p1 + 1; i < p2; i++)
        //    {
        //        if (nums[i] == 0)
        //        {
        //            p1++;
        //            nums[p1] = 0;
        //        }
        //        else if(nums[i] == 2)
        //        { 
        //            if(nums[p2 - 1] == 0)
        //            {
        //                p1++;
        //                nums[p1] = 0;
        //            }
        //            else if(nums[p2 - 1] == 1)
        //            {
        //                oneExists = true;
        //            }
        //            p2--;
        //            nums[p2] = 2;
        //        }
        //        else
        //        {
        //            oneExists = true;
        //        }
        //    }

        //    for (int i = p1 + 1; oneExists && i < p2; i++)
        //    {
        //        nums[i] = 1;
        //    }
        //}
    }
}
