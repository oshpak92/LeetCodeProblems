using Interviewbit.Problems.TimeComplexity;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interviewbit.Problems.Tests.TimeComplexity
{
    public class TimeComplexity
    {
        [Fact]
        public void FindMinPathSolutionTest()
        {
            var solution = new FindMinPathSolution();

            var vector = new List<List<int>>() { new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 } };
            solution.CallsCount = 0;
            solution.FindMinPath(vector, 0, 0);
            Assert.Equal(17, solution.CallsCount);
            Assert.Equal(16, solution.CallsCount2);
        }
    }
}
