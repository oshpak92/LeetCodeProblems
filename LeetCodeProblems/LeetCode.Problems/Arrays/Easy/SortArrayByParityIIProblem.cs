using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 922. Sort Array By Parity II
    /// https://leetcode.com/problems/sort-array-by-parity-ii/
    /// Runtime: 344 ms, faster than 68.89% of C# online submissions for Sort Array By Parity II.
    /// </summary>
    public class SortArrayByParityIIProblem
    {
        public int[] SortArrayByParityII(int[] A)
        {
            var output = new int[A.Length];

            int evenNextIndex = 0;
            int oddNextIndex = 1;

            foreach (var item in A)
            {
                if (item % 2 == 0)
                {
                    output[evenNextIndex] = item;
                    evenNextIndex += 2;
                }
                else
                {
                    output[oddNextIndex] = item;
                    oddNextIndex += 2;
                }
            }

            return output;
        }
    }
}
