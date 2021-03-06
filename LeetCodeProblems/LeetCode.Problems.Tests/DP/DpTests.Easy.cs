﻿using LeetCode.Problems.DP.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.DP
{
    public partial class DpTests
    {
        [Fact]
        public void MaximumSubarrayProblemTest()
        {
            var solution = new MaximumSubarrayProblem();
            Assert.Equal(6, solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 } ));
        }

        [Fact]
        public void MaximumProductofThreeNumbersTest()
        {
            var solution = new MaximumProductofThreeNumbers();
            Assert.Equal(24, solution.MaximumProduct(new int[] { 1, 2, -3, -4 }));
        }

        [Fact]
        public void HouseRobberProblemTest()
        {
            var solution = new HouseRobberProblem();
            Assert.Equal(4, solution.Rob(new int[] { 1, 2, 3, 1}));
            Assert.Equal(1, solution.Rob(new int[] { 1 }));
            Assert.Equal(2, solution.Rob(new int[] { 1, 2 }));
            Assert.Equal(0, solution.Rob(new int[] { }));
            Assert.Equal(4, solution.Rob(new int[] { 2, 1, 1, 2 }));
        }
    }
}
