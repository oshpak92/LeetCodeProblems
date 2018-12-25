using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 905. Sort Array By Parity
    /// https://leetcode.com/problems/sort-array-by-parity/
    /// </summary>
    public class SortArrayByParityProblem
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A == null) throw new ArgumentNullException(nameof(A));
            var last = A.Length - 1;

            for (int i = 0; i < last; i++)
            {
                if(A[i] % 2 != 0)
                {
                    while (last >= 0 && A[last] % 2 != 0)
                        last--;

                    if (last <= i)
                        return A;

                    var tmp = A[last];
                    A[last] = A[i];
                    A[i] = tmp;
                    last--;
                }
            }

            return A;
        }
    }
}
