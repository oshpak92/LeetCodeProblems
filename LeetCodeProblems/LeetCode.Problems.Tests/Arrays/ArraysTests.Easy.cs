using LeetCode.Problems.Arrays.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.Arrays
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
            Assert.Equal(new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 1, 1, 1 } },
                solution.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } }));

            Assert.Equal(new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 1, 0 }, new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 1, 0 } },
                solution.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 1, 0, 0, 1 }, new int[] { 0, 1, 1, 1 }, new int[] { 1, 0, 1, 0 } }));
        }

        [Fact]
        public void ArrayPairSumTest()
        {
            var solution = new ArrayPairSumProblem();

            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 4, 3, 2 }));
            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 2, 3, 4 }));
            Assert.Equal(4, solution.ArrayPairSum(new int[] { 1, 1, 3, 4 }));
        }

        [Fact]
        public void FibTest()
        {
            var solution = new FibonacciNumberProblem();

            Assert.Equal(1, solution.Fib(2));
            Assert.Equal(2, solution.Fib(3));
            Assert.Equal(3, solution.Fib(4));

            Assert.Equal(1, solution.FibRecursive(2));
            Assert.Equal(2, solution.FibRecursive(3));
            Assert.Equal(3, solution.FibRecursive(4));
        }

        [Fact]
        public void SortArrayByParityII()
        {
            var solution = new SortArrayByParityIIProblem();

            Assert.Equal(new int[] { 4, 5, 2, 7 }, solution.SortArrayByParityII(new int[] { 4, 2, 5, 7 }));
        }

        [Fact]
        public void TransposeMatrixProblemTest()
        {
            var solution = new TransposeMatrixProblem();
            var result = solution.Transpose(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
            Assert.Equal(new int[][] { new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 } },
                solution.Transpose(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
            Assert.Equal(new int[][] { new int[] { 1, 4 }, new int[] { 2, 5 }, new int[] { 3, 6 } },
                solution.Transpose(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } }));
        }

        [Fact]
        public void MoveZeroesProblemTest()
        {
            var solution = new MoveZeroesProblem();
            var input1 = new int[] { 0, 1, 0, 3, 12 };
            solution.MoveZeroes(input1);
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, input1);

            var input2 = new int[] { 0, 1, 0, -3, 0 };
            solution.MoveZeroes(input2);
            Assert.Equal(new int[] { 1, -3, 0, 0, 0 }, input2);
        }


        [Fact]
        public void MajorityElementProblemTest()
        {
            var solution = new MajorityElementProblem();
            Assert.Equal(3, solution.MajorityElement(new int[] { 3, 2, 3 }));
            Assert.Equal(2, solution.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        [Fact]
        public void ContainsDuplicateProblemTest()
        {
            var solution = new ContainsDuplicateProblem();
            Assert.True(solution.ContainsDuplicate(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        }
    }
}
