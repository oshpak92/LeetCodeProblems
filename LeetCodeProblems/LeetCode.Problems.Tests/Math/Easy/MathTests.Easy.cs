using LeetCode.Problems.Math.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Math.Easy
{
    public class MathTests
    {
        [Fact]
        public void ReverseIntegerTest()
        {
            var solution = new ReverseInteger();
            Assert.Equal(321, solution.Reverse(123));
            Assert.Equal(-321, solution.Reverse(-123));
            Assert.Equal(21, solution.Reverse(120));
            Assert.Equal(-1, solution.Reverse(-1));
            Assert.Equal(0, solution.Reverse(0));
            Assert.Equal(0, solution.Reverse(1534236469));
            Assert.Equal(0, solution.Reverse(-2147483648));
        }

        [Fact]
        public void FactorialTrailingZeroesProblemTest()
        {
            var solution = new FactorialTrailingZeroesProblem();
            Assert.Equal(0, solution.TrailingZeroes(3));
            Assert.Equal(1, solution.TrailingZeroes(5));
            Assert.Equal(3, solution.TrailingZeroes(15));
            Assert.Equal(7, solution.TrailingZeroes(30));
        }
    }
}
