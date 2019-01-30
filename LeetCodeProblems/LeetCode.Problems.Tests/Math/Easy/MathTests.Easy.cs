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


        [Fact]
        public void RomantoIntegerProblemTest()
        {
            var solution = new RomantoIntegerProblem();
            Assert.Equal(3, solution.RomanToInt("III"));
            Assert.Equal(4, solution.RomanToInt("IV"));
            Assert.Equal(9, solution.RomanToInt("IX"));
            Assert.Equal(58, solution.RomanToInt("LVIII"));
            Assert.Equal(1994, solution.RomanToInt("MCMXCIV"));
        }

        [Fact]
        public void ExcelSheetColumnNumberProblemTest()
        {
            var solution = new ExcelSheetColumnNumberProblem();
            Assert.Equal(1, solution.TitleToNumber("A"));
            Assert.Equal(28, solution.TitleToNumber("AB"));
            Assert.Equal(701, solution.TitleToNumber("ZY"));
            Assert.Equal(703, solution.TitleToNumber("AAA"));
        }

        [Fact]
        public void HappyNumberProblemTest()
        {
            var solution = new HappyNumberProblem();
            Assert.True(solution.IsHappy(19));
            Assert.False(solution.IsHappy(2));
        }

        [Fact]
        public void PowerofThreeProblemTest()
        {
            var solution = new PowerofThreeProblem();
            Assert.True(solution.IsPowerOfThree(27));
        }

        [Fact]
        public void SqrtxProblemTest()
        {
            var solution = new SqrtxProblem();
            Assert.Equal(6, solution.MySqrt(36));
            Assert.Equal(4, solution.MySqrt(16));
            Assert.Equal(3, solution.MySqrt(9));
        }
    }
}
