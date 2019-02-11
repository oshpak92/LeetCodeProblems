using LeetCode.Problems.Strings;
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
    }
}
