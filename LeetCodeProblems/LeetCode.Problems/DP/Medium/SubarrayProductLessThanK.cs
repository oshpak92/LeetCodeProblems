using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.DP.Medium
{
    public class SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int l = 0, h = 0, count = 0;
            var singleVal = new HashSet<int>();
            int[] mem = new int[nums.Length];
            for (int i = 0; i < mem.Length; i++)
                mem[i] = -1;

            mem[0] = nums[0];

            while (h < nums.Length && l < nums.Length)
            {
                if (nums[l] >= k) { l++; continue; }
                if (l >= h)
                {
                    if(mem[h] == -1)
                    {
                        mem[h] = nums[h];
                        if (nums[h] < k) count++;
                    }
                    h++;
                    continue;
                }

                Expand(nums, mem, k, ref l, ref h, ref count);
                Shrink(nums, mem, k, ref l, ref h, ref count);

                if (h == l && nums[h] >= k)
                {
                    h++; l++;
                }
            }

            while (l < h - 1)
            {
                count++;
                l++;
            }

            return count;
        }

        private void Expand(int[] nums, int[] mem, int k,
            ref int l, ref int h, ref int count)
        {
            while (h < nums.Length)
            {
                if (nums[h] < k)
                {
                    if (mem[h] == -1)
                    {
                        mem[h] = nums[h];
                        count++;
                    }

                    var product = mem[h - 1] * nums[h];
                    if (product < k)
                    {
                        count++;
                        mem[h] = product;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
                h++;
            }
        }

        private void Shrink(int[] nums, int[] mem, int k,
            ref int l, ref int h, ref int count)
        {
            if (l + 1 < h)
            {
                mem[h - 1] = mem[h - 1] / nums[l];
            }
            l++;
        }
    }
}
