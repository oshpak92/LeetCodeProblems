using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 832. Flipping an Image
    /// https://leetcode.com/problems/flipping-an-image/
    /// Efficiency 95%
    /// </summary>
    public class FlippingAnImageSolution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            foreach (var row in A)
            {
                for (var j = 0; j < (A.Length + 1) / 2; ++j)
                {
                    var tmp = row[j] ^ 1;
                    row[j] = row[A.Length - 1 - j] ^ 1;
                    row[A.Length - 1 - j] = tmp;
                }
            }

            return A;
        }
    }
}
