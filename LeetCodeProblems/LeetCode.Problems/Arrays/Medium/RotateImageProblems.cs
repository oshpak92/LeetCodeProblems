using LeetCode.Problems.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 48. Rotate Image
    /// https://leetcode.com/problems/rotate-image/
    /// Runtime: 112 ms, faster than 81.82% of C# online submissions for Rotate Image.
    /// </summary>
    public class RotateImageProblems
    {
        public void Rotate(int[,] matrix)
        {
            var length = matrix.GetLength(0);
            if (length < 2)
                return;

            var i = 0;
            var j = 0;


            while (length > 1 && i < matrix.GetLength(0)/2)
            {
                var nexti = j;
                var nextj = matrix.GetLength(0) - 1 - i;
                var index = 0;
                var buf = new int[5];
                buf[0] = matrix[i, j]; 
                while (index < 4)
                {
                    buf[index + 1] = matrix[nexti, nextj];  
                    matrix[nexti, nextj] = buf[index];
                    var tmpindex = nexti;
                    nexti = nextj;
                    nextj = matrix.GetLength(0) - 1 - tmpindex;
                    index++;
                }
                Helperrs.PrintMatrix(matrix);

                if (j < length-2) j++;
                else
                {
                    i++; j = i; length--;
                }
            }
             
        }
    }
}
