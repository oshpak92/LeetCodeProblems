using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 279. Perfect Squares
    /// https://leetcode.com/problems/perfect-squares/
    /// Runtime: 116 ms, faster than 66.67% of C# online submissions for Perfect Squares.
    /// Memory Usage: 6.7 MB, less than 38.46% of C# online submissions for Perfect Squares.
    /// </summary>
    public class PerfectSquaresProblem
    {
        public int NumSquares(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int[] cntPerfectSquares = new int[n + 1];

            for (int i = 0; i < cntPerfectSquares.Length; i++)
            {
                cntPerfectSquares[i] = int.MaxValue;
            }

            // cntPerfectSquares[i] = the least number of perfect square numbers
            // which sum to i. Note that cntPerfectSquares[0] is 0.
            cntPerfectSquares[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                // For each i, it must be the sum of some number (i - j*j) and 
                // a perfect square number (j*j).
                for (int j = 1; j * j <= i; j++)
                {
                    cntPerfectSquares[i] =
                        System.Math.Min(cntPerfectSquares[i], cntPerfectSquares[i - j * j] + 1);
                }
            }

            return cntPerfectSquares[n];
        }

        //public int NumSquares(int n)
        //{
        //    var psq = new List<int>();
        //    for (int i = 1; i*i <= n; i++)
        //    {
        //        psq.Add(i*i);
        //    }
        //    var Length = psq.Count;
        //    var sum = 0;
        //    var result = new List<int>();
        //    for (int i = Length - 1; i >= 0 && sum != n; i--)
        //    {
        //        var dif = n % psq[i];
        //        while (dif >= 0)
        //        {
        //            sum += psq[i];
        //            result.Add(psq[i]);
        //            dif -= psq[i];
        //        }
        //    }
        //    return result.Count;
        //}
    }
}
