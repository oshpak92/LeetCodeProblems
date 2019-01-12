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

        [Fact]
        public void FlippingAnImageTest()
        {
            var solution = new FlippingAnImageSolution();
            Assert.Equal(new int[][] { new int[] { 1, 0, 0}, new int[] { 0, 1, 0}, new int[] { 1, 1, 1} }, 
                solution.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0 } , new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } }));

            Assert.Equal(new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 1, 0 }, new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 1, 0 } }, 
                solution.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0, 0 } , new int[] { 1, 0, 0, 1 }, new int[] { 0, 1, 1, 1 }, new int[] { 1, 0, 1, 0 } }));
        }

        [Fact]
        public void ArrayPairSumTest()
        {
            var solution = new ArrayPairSumProblem();

            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 4, 3, 2 }));
            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 2, 3, 4 }));
            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 1, 3, 4 }));
        }


    }
}
