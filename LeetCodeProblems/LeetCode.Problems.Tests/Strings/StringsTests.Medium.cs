using LeetCode.Problems.Strings.Easy;
using LeetCode.Problems.Strings.Medium;
using System;
using System.Collections.Generic;
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
    }
}
