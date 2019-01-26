using LeetCode.Problems.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 73. Set Matrix Zeroes
    /// https://leetcode.com/problems/set-matrix-zeroes/
    /// Runtime: 176 ms, faster than 54.55% of C# online submissions for Set Matrix Zeroes.
    /// </summary>
    public class SetMatrixZeroesProblem
    {
        public void SetZeroes(int[,] matrix)
        {
            var n = matrix.GetLength(0);
            var m = matrix.GetLength(1);

            var row = 0;
            var column = 0;

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        if (i == 0)
                            row = 1;
                        if (j == 0)
                            column = 1;

                        matrix[0, j] = 0;
                        matrix[i, 0] = 0;
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, 0] == 0)
                {
                    for (int j = 1; j < m; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for (int j = 1; j < m; j++)
            {
                if (matrix[0, j] == 0)
                {
                    for (int i = 1; i < n; i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            if (row == 1)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[0, j] = 0;
                }
            }
            if (column == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i, 0] = 0;
                }
            }
        }
    }
}
