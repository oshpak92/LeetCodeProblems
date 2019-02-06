using LeetCode.Problems.Math.Easy;
using LeetCode.Problems.Math.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Math.Medium
{
    public class MathTests
    {
        [Fact]
        public void PerfectSquaresProblemTest()
        {
            var solution = new PerfectSquaresProblem();
            Assert.Equal(3, solution.NumSquares(12));
        }
    }
}
