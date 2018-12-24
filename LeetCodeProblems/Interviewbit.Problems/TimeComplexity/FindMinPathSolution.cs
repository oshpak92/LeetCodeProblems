using System;
using System.Collections.Generic;
using System.Text;

namespace Interviewbit.Problems.TimeComplexity
{
    public class FindMinPathSolution
    {
        private int[,] memo = new int[101, 101];

        public int FindMinPath(List<List<int>> V, int r, int c)
        {
            CallsCount++;
            int R = V.Count;
            int C = V[0].Count;
            if (r >= R || c >= C) return 100000000; // Infinity
            if (r == R - 1 && c == C - 1) return 0;
            if (memo[r, c] != 0) return memo[r, c];
            CallsCount2 += 2;
            memo[r, c] = V[r][c] + Min(FindMinPath(V, r + 1, c), FindMinPath(V, r, c + 1));
            return memo[r, c];
        }

        private int Min(int left, int right)
        {
            return left <= right ? left : right;
        }

        public int CallsCount { get; set; }

        public int CallsCount2 { get; set; }

    }
}
