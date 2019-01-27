using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Utils
{
    public class Helperrs
    {
        public static int [] Shift(int [] arr, int startIndex, int lastIndex)
        {
            for (var i = startIndex; i < lastIndex; i++)
            {
                var tmp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = tmp;
            }

            return arr;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    builder.Append(matrix[i,j]).Append(",");
                }
                builder.AppendLine();
            }

            Debug.WriteLine(builder.ToString());
        }


        public static void PrintMatrix(int[][] matrix)
        {
            var builder = new StringBuilder();
            var n = matrix[0].Length;
            var m = matrix.GetLength(0);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    builder.Append(matrix[i][j]).Append(",");
                }
                builder.AppendLine();
            }

            Debug.WriteLine(builder.ToString());
        }
    }
}
