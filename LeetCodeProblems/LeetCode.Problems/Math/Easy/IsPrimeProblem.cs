using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    /// <summary>
    /// 204. Count Primes
    /// https://leetcode.com/problems/count-primes/submissions/
    /// Runtime: 68 ms, faster than 91.30% of C# online submissions for Count Primes.
    /// Memory Usage: 7.5 MB, less than 38.10% of C# online submissions for Count Primes.
    /// </summary>
    public class IsPrimeProblem
    {
        public int CountPrimes(int n)
        {
            var flags = new bool[n];
            for (int i = 2; i < n; i++)
                flags[i] = true;

            var count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!flags[i]) continue;

                for (int j = i * i; j < n; j += i)
                {
                    flags[j] = false;
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (flags[i])
                    count++;
            }

            return count;
        }

        //public int CountPrimes(int n)
        //{
        //    var count = 0;

        //    for (int i = 2; i < n; i++)
        //    {
        //        if (IsPrime(i))
        //            count++;
        //    }

        //    return count;
        //}

        //private bool IsPrime(int n)
        //{
        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        if (n % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
    }
}
