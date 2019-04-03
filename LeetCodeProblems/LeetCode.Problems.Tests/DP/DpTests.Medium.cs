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
    }
}
