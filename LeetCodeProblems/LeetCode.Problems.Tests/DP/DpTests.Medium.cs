using LeetCode.Problems.DP.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.DP
{
    public partial class DpTests
    {
        [Fact]
        public void LongestPalindromicSubstringProblemTest()
        {
            var solution = new LongestSubstringwithAtLeastKRepeatingCharactersProblem();

            Assert.Equal(5, solution.LongestSubstring("ababbc", 2));
        }

        [Fact]
        public void MaximumProductSubarrayProblemTest()
        {
            var solution = new MaximumProductSubarrayProblem();

            Assert.Equal(6, solution.MaxProduct(new int[] { 2, 3, -2, 4 }));
            Assert.Equal(0, solution.MaxProduct(new int[] { -2, 0, -1 }));
            Assert.Equal(24, solution.MaxProduct(new int[] { -2, 3, -4 }));
            Assert.Equal(4, solution.MaxProduct(new int[] { 3, -1, 4 }));
            Assert.Equal(16, solution.MaxProduct(new int[] { 3, -1, 4, 4 }));
            Assert.Equal(12, solution.MaxProduct(new int[] { -4, -3 }));
            Assert.Equal(24, solution.MaxProduct(new int[] { 2, -5, -2, -4, 3 }));
            Assert.Equal(432, solution.MaxProduct(new int[] { 1, -2, 3, -4, -3, -4, -3 }));
            Assert.Equal(6, solution.MaxProduct(new int[] { -1, -2, -3, 0 }));
            Assert.Equal(27, solution.MaxProduct(new int[] { 0, -3, 1, 3, -3, -1, 2 }));
            Assert.Equal(2400, solution.MaxProduct(new int[] {1, -2, 0, 1, -4, 1, 1, 5, 4, -1, 6, 4, 1, -5, 0, -1, -5, 1, -6, -4}));
        }
    }
}
