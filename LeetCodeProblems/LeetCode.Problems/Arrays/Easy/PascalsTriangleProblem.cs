using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 118. Pascal's Triangle
    /// https://leetcode.com/problems/pascals-triangle/
    /// Runtime: 260 ms, faster than 58.11% of C# online submissions for Pascal's Triangle.
    /// </summary>
    public class PascalsTriangleProblem
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var currentRow = 0;

            while (currentRow < numRows)
            {
                var row = new List<int>();
                for (int i = 0; i <= currentRow; i++)
                {
                    if (i == 0 || i == currentRow)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(result[currentRow - 1][i - 1] + result[currentRow - 1][i]);
                    }
                }
                result.Add(row);
                currentRow++;
            }

            return result;
        }
    }
}
