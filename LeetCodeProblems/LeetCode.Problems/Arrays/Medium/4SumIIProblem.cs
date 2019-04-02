using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    public class FourSumIIProblem
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var length = A.Length;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    var sum = A[i] + B[j];
                    dict[sum] = dict.GetValueOrDefault(sum, 0) + 1;
                }
            }

            var result = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    result += dict.GetValueOrDefault(-1* (C[i] + D[j]), 0);
                }
            }

            return result;
        }
    }
}
