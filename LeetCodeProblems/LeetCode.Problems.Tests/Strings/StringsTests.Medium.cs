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

        [Fact]
        public void LongestPalindromicSubstringProblemTest()
        {
            var solution = new LongestPalindromicSubstringProblem();

            Assert.Contains(solution.LongestPalindrome("babadada"), new List<string>() { "adada" });
            Assert.Contains(solution.LongestPalindrome("babad"), new List<string>() { "bab", "aba" });
            Assert.Contains(solution.LongestPalindrome("cbbd"), new List<string>() { "bb" });
            Assert.Contains(solution.LongestPalindrome("ccbd"), new List<string>() { "cc" });
            Assert.Contains(solution.LongestPalindrome("cc"), new List<string>() { "cc" });
            Assert.Contains(solution.LongestPalindrome("c"), new List<string>() { "c" });
            Assert.Contains(solution.LongestPalindrome(""), new List<string>() { "" });
            Assert.Contains(solution.LongestPalindrome(null), new List<string>() { null });
            Assert.Contains(solution.LongestPalindrome("ac"), new List<string>() { "a", "c" });
            Assert.Contains(solution.LongestPalindrome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabcaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), new List<string>() { "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" });
            Assert.Contains(solution.LongestPalindrome("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"), new List<string>() { "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb" });

        }

        [Fact]
        public void DecodeWaysProblemTest()
        {
            var solution = new DecodeWaysProblem();

            Assert.Equal(0, solution.NumDecodings("0"));

            Assert.Equal(2, solution.NumDecodings("12"));
            Assert.Equal(0, solution.NumDecodings(""));
            Assert.Equal(3, solution.NumDecodings("226"));
            Assert.Equal(3, solution.NumDecodings("111"));
            Assert.Equal(3, solution.NumDecodings("2261"));
            Assert.Equal(3981312, solution.NumDecodings("9371597631128776948387197132267188677349946742344217846154932859125134924241649584251978418763151253"));
            Assert.Equal(5898240, solution.NumDecodings("1787897759966261825913315262377298132516969578441236833255596967132573482281598412163216914566534565"));
        }

        [Fact]
        public void BasicCalculatorIIProblemTest()
        {
            var solution = new BasicCalculatorIIProblem();

            Assert.Equal("1 2 +", solution.ToPostfix("   1 + 2"));
            Assert.Equal("1 2 3 *+", solution.ToPostfix("1 + 2 * 3"));
            Assert.Equal(3, solution.Calculate("1 + 2"));
            Assert.Equal(5, solution.Calculate("1 + 2 * 2"));
            Assert.Equal(2, solution.Calculate("1 / 2 + 2 * 2 /     2"));
        }

        [Fact]
        public void IntersectionofTwoArraysIIProblemTest()
        {
            var solution = new IntersectionofTwoArraysIIProblem();

            Assert.Equal(new int[] { 2, 2 }, solution.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }));
            Assert.Equal(new int[] { 4, 9 }, solution.Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }));
            Assert.Equal(new int[] { }, solution.Intersect(new int[] { }, new int[] { 9, 4, 9, 8, 4 }));
        }
    }
}
