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
    }
}
