using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 867. Transpose Matrix
    /// https://leetcode.com/problems/transpose-matrix/
    /// Runtime: 328 ms, faster than 45.83% of C# online submissions for Transpose Matrix.
    /// </summary>
    public class TransposeMatrixProblem
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] resultMatrix = new int[A[0].Length][];
            for (var i=0; i<resultMatrix.Length;i++)
            {
                resultMatrix[i] = new int[A.Length];
            }

            for (var i = 0; i < A.Length; i++)
            {
                for (var j = 0; j < A[0].Length; j++)
                {
                    if (i == j)
                    {
                        resultMatrix[i][j] = A[i][j];
                    }
                    else
                    {
                        resultMatrix[j][i] = A[i][j];
                    }
                }
            }

            return resultMatrix;
        }
        //Input:    [1,2,3],
        //          [4,5,6]
        //Output:   [1,4],
        //          [2,5],
        //          [3,6]

    }
}
