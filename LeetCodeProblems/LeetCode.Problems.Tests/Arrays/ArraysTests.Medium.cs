using LeetCode.Problems.Arrays.Easy;
using LeetCode.Problems.Arrays.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Arrays
{
    public partial class ArraysTests
    {
        [Fact]
        public void PancakeSortTest()
        {
            var solution = new PancakeSortingProblem();
            Assert.Equal(new int[] { 2, 3, 4, 1 }, solution.Flip(new int[] { 3, 2, 4, 1 }, 1));

            var pancakeSort = solution.PancakeSort(new int[] { 3, 2, 4, 1 });
            Assert.Equal(new int[] { 3, 4, 2, 3, 2 }, solution.PancakeSort(new int[] { 3, 2, 4, 1 }));
            Assert.Equal(new int[] { }, solution.PancakeSort(new int[] { 1,2,3 }));
        }

        [Fact]
        public void FindtheDuplicateNumberProblemTest()
        {
            var solution = new FindtheDuplicateNumberProblem();
            Assert.Equal(2, solution.FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
            Assert.Equal(3, solution.FindDuplicate(new int[] { 3, 1, 3, 4, 2 }));
        }

        [Fact]
        public void FindAllDuplicatesinanArrayProblemTest()
        {
            var solution = new FindAllDuplicatesinanArrayProblem();
            Assert.Equal(new List<int>() { 2, 3 }, solution.FindDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        }
    }
}
