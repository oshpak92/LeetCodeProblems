using LeetCode.Problems.Strings;
using LeetCode.Problems.Strings.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Strings
{
    public partial class StringsTests
    {
        [Fact]
        public void ReverseStringProblemTest()
        {
            var solution = new ReverseStringProblem();
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            solution.ReverseString(input);
            Assert.Equal(new char[] { 'o', 'l', 'l', 'e', 'h' }, input);

            input = new char[] { 'h' };
            solution.ReverseString(input);
            Assert.Equal(new char[] { 'h' }, input);

            input = new char[] {  };
            solution.ReverseString(input);
            Assert.Equal(new char[] {  }, input);

            input = new char[] { 'h', 'e' };
            solution.ReverseString(input);
            Assert.Equal(new char[] { 'e', 'h' }, input);
        }

        [Fact]
        public void FirstUniqueCharacterinaStringProblemTest()
        {
            var solution = new FirstUniqueCharacterinaStringProblem();
            Assert.Equal(0, solution.FirstUniqChar("leetcode"));
            Assert.Equal(2, solution.FirstUniqChar("loveleetcode"));
        }

        [Fact]
        public void ImplementstrStrProblemTest()
        {
            var solution = new ImplementstrStrProblem();
            Assert.Equal(2, solution.StrStr("hello", "ll"));
            Assert.Equal(-1, solution.StrStr("aaaaa", "bba"));
            Assert.Equal(0, solution.StrStr("mississippi", "mississippi"));
        }

        [Fact]
        public void LongestCommonPrefixProblemTest()
        {
            var solution = new LongestCommonPrefixProblem();
            Assert.Equal("fl", solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
            Assert.Equal("", solution.LongestCommonPrefix(new string[] { "", "flow", "flight" }));
            Assert.Equal("f", solution.LongestCommonPrefix(new string[] { "f", "flow", "flight" }));
            Assert.Equal("f", solution.LongestCommonPrefix(new string[] { "flow", "f", "flow", "flight" }));
            Assert.Equal("", solution.LongestCommonPrefix(new string[] { "flow", null, "flow", "flight" }));
            Assert.Equal("flow", solution.LongestCommonPrefix(new string[] { "flow", "flow", "flow", "flow" }));
        }


        [Fact]
        public void ValidPalindromeProblemTest()
        {
            var solution = new ValidPalindromeProblem();
            Assert.True(solution.IsPalindrome("A man, a plan, a canal: Panama"));
            Assert.False(solution.IsPalindrome("race a car"));
        }
    }
}
