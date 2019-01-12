using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 509. Fibonacci Number
    /// https://leetcode.com/problems/fibonacci-number/
    /// Efficiency 100%
    /// do not use recursion here because recursion wil give O(2^N) current implementation provides O(N)
    /// </summary>
    public class FibonacciNumberProblem
    {
        public int Fib(int N)
        {
            if (N <= 1)
                return N;

            int a = 0, b = 1;

            while (N-- > 1)
            {
                int sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

        public int FibRecursive(int N)
        {
            if (N <= 1)
                return N;

            return FibRecursive(N - 1) + FibRecursive(N - 2); 
        }
    }
}
