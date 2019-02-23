using LeetCode.Problems.Strings.Easy;
using LeetCode.Problems.Strings.Medium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Strings
{
    public partial class StringsTests
    {
        [Fact]
        public void GenerateParenthesesProblemTest()
        {
            var solution = new GenerateParenthesesProblem();
            var result = solution.GenerateParenthesis(3);
            Assert.Equal(5, result.Count());

            var braketsValidator = new ValidParenthesesProblem();
            foreach(var item in result)
            {
                Assert.True(braketsValidator.IsValid(item));
            }
        }

        [Fact]
        public void GroupAnagramsProblemTest()
        {
            var solution = new GroupAnagramsProblem();
            var result = solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" } );
            Assert.Equal(10, solution.GroupAnagrams(new string[] { "cab", "tin", "pew", "duh", "may", "ill", "buy", "bar", "max", "doc"} ).Count);

            Assert.NotEqual(solution.SumStr("duh"), solution.SumStr("ill"));

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void LetterCombinationsofaPhoneNumberProblemTest()
        {
            var solution = new LetterCombinationsofaPhoneNumberProblem();
            var result = solution.LetterCombinations("23");
            foreach (var word in result)
            {
                Debug.WriteLine(result);
            }
        }

        [Fact]
        public void LongestSubstringWithoutRepeatingCharactersProblemTest()
        {
            var solution = new LongestSubstringWithoutRepeatingCharactersProblem();
            var result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.Equal(3, result);
            Assert.Equal(1, solution.LengthOfLongestSubstring("bbbbb"));
            Assert.Equal(3, solution.LengthOfLongestSubstring("pwwkew"));
            Assert.Equal(1, solution.LengthOfLongestSubstring("b"));
            Assert.Equal(0, solution.LengthOfLongestSubstring(""));
            Assert.Equal(2, solution.LengthOfLongestSubstring("au"));
            Assert.Equal(5, solution.LengthOfLongestSubstring("tmmzuxt"));
        }
    }
}
