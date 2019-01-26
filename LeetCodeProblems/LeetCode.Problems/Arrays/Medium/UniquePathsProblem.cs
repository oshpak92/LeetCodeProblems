using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 62. Unique Paths
    /// https://leetcode.com/problems/unique-paths/
    /// Runtime: 44 ms, faster than 100.00% of C# online submissions for Unique Paths.
    /// </summary>
    public class UniquePathsProblem
    {
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[n + 1, m + 1];
            dp[1,0] = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    dp[i,j] = dp[i - 1,j] + dp[i,j - 1];
                }
            }
            return dp[n,m];
        }

        //private int counter = 0;
        //public int iterationCount = 0;
        //public int UniquePaths(int m, int n)
        //{
        //    counter = 0;

        //    if (n == 0 && m != 0 || m == 0 && n != 0)
        //        counter++;
        //    else if (n * m == 0)
        //        counter = 0;
        //    else
        //        Walker(m, n, 0, 0);

        //    return counter;
        //}

        //private void Walker(int m, int n, int i, int j)
        //{
        //    iterationCount++;   
        //    Debug.WriteLine($"({i}, {j})");
        //    if (i == n - 1 && j == m - 1)
        //        counter++;

        //    if (i + 1 < n)
        //        Walker(m,n, i+1, j);

        //    if (j + 1 < m)
        //        Walker(m, n, i, j + 1);
        //}
    }
}
