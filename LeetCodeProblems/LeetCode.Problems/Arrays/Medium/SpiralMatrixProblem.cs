using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 54. Spiral Matrix
    /// https://leetcode.com/problems/spiral-matrix/
    /// Runtime: 280 ms, faster than 100.00% of C# online submissions for Spiral Matrix.
    /// </summary>
    public class SpiralMatrixProblem
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var output = new int[matrix.Length];
            if (matrix.Length == 0)
                return output;

            var index = 0;
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var j = 0;
            var i = 0;

            var counter = 0; 
            while (index < output.Length)
            {
                for(i = counter, j = counter; j < n; j++)
                {
                    output[index++] = matrix[i, j];
                }

                for(i++, j=n-1; i < m && index < output.Length; i++)
                {
                    output[index++] = matrix[i, j];
                }

                for (j --, i = m - 1; j >= counter && index < output.Length; j -- )
                {
                    output[index++] = matrix[i, j];
                }

                for (i --, j++; i > counter && index < output.Length; i-- )
                {
                    output[index++] = matrix[i, j];
                }
                n = n - 1;
                m = m - 1;
                counter++;
            }

            return output;
        }
    }
}
