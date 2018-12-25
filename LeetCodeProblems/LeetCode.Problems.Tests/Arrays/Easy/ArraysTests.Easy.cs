using LeetCode.Problems.Arrays.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Arrays.Easy
{
    public partial class ArraysTests
    {
        [Fact]
        public void SortArrayByParityTest()
        {
            var solution = new SortArrayByParityProblem();
            Assert.Equal(new int[] { 4, 2, 1, 3 }, solution.SortArrayByParity(new int[] { 3, 1, 2, 4 }));
            Assert.Equal(new int[] { 4, 2, 1, 3 }, solution.SortArrayByParity(new int[] { 4, 1, 2, 3 }));
            Assert.Equal(new int[] { 1, 3, 5, 7 }, solution.SortArrayByParity(new int[] { 1, 3, 5, 7 }));
            Assert.Equal(new int[] { 2, 4, 6, 8 }, solution.SortArrayByParity(new int[] { 2, 4, 6, 8 }));
            Assert.Equal(new int[] { 0, 1, 3 }, solution.SortArrayByParity(new int[] { 0, 1, 3 }));
            Assert.Equal(new int[] { 1, 3, 5 }, solution.SortArrayByParity(new int[] { 1, 3, 5 }));
        }
    }
}
