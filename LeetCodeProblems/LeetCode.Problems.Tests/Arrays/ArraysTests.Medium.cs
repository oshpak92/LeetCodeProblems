using LeetCode.Problems.Arrays.Easy;
using LeetCode.Problems.Arrays.Medium;
using LeetCode.Problems.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using static LeetCode.Problems.Arrays.Medium.RotateListProblem;

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
            Assert.Equal(new int[] { }, solution.PancakeSort(new int[] { 1, 2, 3 }));
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

        [Fact]
        public void ProductofArrayExceptSelfProblemTest()
        {
            var solution = new ProductofArrayExceptSelfProblem();
            Assert.Equal(new int[] { 24, 12, 8, 6 }, solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 }));
        }

        [Fact]
        public void RotateImageProblemsTest()
        {
            var solution = new RotateImageProblems();

            var matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            //var matrix = new int[,] { { 1, 2, 3 }, {4, 5, 6}, {7, 8, 9 } };

            Helperrs.PrintMatrix(matrix);
            solution.Rotate(matrix);
            Helperrs.PrintMatrix(matrix);
        }

        [Fact]
        public void GameOfLifeProblemTest()
        {
            var solution = new GameOfLifeProblem();

            var matrix = new int[][] { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } };

            Helperrs.PrintMatrix(matrix);
            solution.GameOfLife(matrix);
            Helperrs.PrintMatrix(matrix);
        }



        [Fact]
        public void RotateListProblemTest()
        {
            var solution = new RotateListProblem();
            var head = new ListNode(0)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = null
                                }
                            }
                        }
                    }
                }
            };
            print(head);
            Debug.WriteLine($"==============================================");
            var newHead = solution.RotateRight(head, 2000000000);
            print(newHead);
            Debug.WriteLine($"==============================================");
            var head2 = new ListNode(0);
            print(head2);
            Debug.WriteLine($"==============================================");
            var newHead1 = solution.RotateRight(head2, 2);
            print(newHead1);
            Debug.WriteLine($"==============================================");

            var head3 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = null
                }
            };
            print(head3);
            var newHead3 = solution.RotateRight(head3, 2);
            print(newHead3);
        }

        private void print(ListNode node)
        {
            Debug.Write($"[{node.val}]");

            if (node.next == null)
                return;

            print(node.next);
        }


        [Fact]
        public void SearchinRotatedSortedArrayProblemTests()
        {
            var solution = new SearchinRotatedSortedArrayProblem();
            Assert.Equal(1, solution.Search(new int[] { 4, 5, 6, 7, 8, 1, 2 }, 5));
            Assert.Equal(-1, solution.Search(new int[] { 4, 5, 6, 7, 8, 1, 2 }, 10));
            Assert.Equal(4, solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
            Assert.Equal(-1, solution.Search(new int[] { 1 }, 0));
            Assert.Equal(-1, solution.Search(new int[] { 1, 3 }, 0));
            Assert.Equal(-1, solution.Search(new int[] { 1, 3 }, 2));

            Assert.Equal(-1, solution.Search(new int[] { 1, 3, 5 }, 4));
            Assert.Equal(-1, solution.Search(new int[] { 3, 5, 1 }, 0));
            Assert.Equal(-1, solution.Search(new int[] { 5, 1, 3 }, 0));
            Assert.Equal(3, solution.Search(new int[] { 7, 8, 1, 2, 3, 4, 5, 6 }, 2));
            Assert.Equal(0, solution.Search(new int[] { 3, 1 }, 3));
        }

        [Fact]
        public void SearchinRotatedSortedArraySearchPivotTest()
        {
            var solution = new SearchinRotatedSortedArrayProblem();
            Assert.Equal(4, solution.searchPivot(new int[] { 4, 5, 6, 7, 8, 1, 2 }, 0, 6));
            Assert.Equal(3, solution.searchPivot(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 6));
            Assert.Equal(0, solution.searchPivot(new int[] { 1 }, 0, 0));
            Assert.Equal(1, solution.searchPivot(new int[] { 1, 3 }, 0, 1));
            Assert.Equal(1, solution.searchPivot(new int[] { 1, 3 }, 0, 1));
            Assert.Equal(2, solution.searchPivot(new int[] { 1, 3, 5 }, 0, 2));
            Assert.Equal(1, solution.searchPivot(new int[] { 3, 5, 1 }, 0, 2));
            Assert.Equal(0, solution.searchPivot(new int[] { 5, 1, 3 }, 0, 2));
            Assert.Equal(1, solution.searchPivot(new int[] { 7, 8, 1, 2, 3, 4, 5, 6 }, 0, 7));
            Assert.Equal(7, solution.searchPivot(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0, 7));
            Assert.Equal(0, solution.searchPivot(new int[] { 3, 1 }, 0, 1));
        }

        [Fact]
        public void FindPeakElementProblemTest()
        {
            var solution = new FindPeakElementProblem();
            Assert.Equal(2, solution.FindPeakElement(new int[] { 1, 2, 3, 1 }));
        }

        [Fact]
        public void ContainerWithMostWaterTest()
        {
            var solution = new ContainerWithMostWaterProblem();
            Assert.Equal(49, solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Assert.Equal(0, solution.MaxArea(new int[] { 0, 2 }));
            Assert.Equal(0, solution.MaxArea(new int[] { 0, 0 }));
            Assert.Equal(2, solution.MaxArea(new int[] { 1, 0, 1 }));
            Assert.Equal(0, solution.MaxArea(new int[] { 1 }));
            Assert.Equal(0, solution.MaxArea(new int[] { }));
        }

        [Fact]
        public void SetMatrixZeroesProblemTest()
        {
            var solution = new SetMatrixZeroesProblem();

            var matrix = new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

            Helperrs.PrintMatrix(matrix);
            solution.SetZeroes(matrix);
            Helperrs.PrintMatrix(matrix);

            var matrix2 = new int[,] { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);

            matrix2 = new int[,] { { 1, 0 } };

            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);

            matrix2 = new int[,] { { 0 }, { 1 } };

            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);

            matrix2 = new int[,] { { 0 } };

            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);


            matrix2 = new int[,] { { 1 } };

            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);

            matrix2 = new int[,] { { 1, 1, 1 }, { 0, 1, 2 } };
            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);

            matrix2 = new int[,] { { 1, 0, 3 } };
            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);


            matrix2 = new int[,] { { -4, -2, 6, -7, 0 }, { -8, 6, -8, -6, 0 }, { 7, 2, -9, -6, -1 } };
            Helperrs.PrintMatrix(matrix2);
            solution.SetZeroes(matrix2);
            Helperrs.PrintMatrix(matrix2);
        }

        [Fact]
        public void UniquePathsProblemTest()
        {
            var solution = new UniquePathsProblem();
            Assert.Equal(3, solution.UniquePaths(3, 2));
            Assert.Equal(2, solution.UniquePaths(2, 2));
            Assert.Equal(1, solution.UniquePaths(1, 2));
            //Assert.Equal(1, solution.UniquePaths(1, 0));
            //Assert.Equal(0, solution.UniquePaths(0, 0));
            Assert.Equal(70, solution.UniquePaths(5, 5));
        }

        [Fact]
        public void MergeIntervalsProblemTest()
        {
            var solution = new MergeIntervalsProblem();
            Assert.Equal(3, solution.Merge(new List<Interval>() {
                new Interval(1,3),
                new Interval(2,6),
                new Interval(8,10),
                new Interval(15,18)
            }).Count);

            Assert.Equal(1, solution.Merge(new List<Interval>() {
                new Interval(1,4),
                new Interval(4,5)
            }).Count);

            Assert.Equal(1, solution.Merge(new List<Interval>() {
                new Interval(1,4)
            }).Count);

            Assert.Equal(0, solution.Merge(new List<Interval>()
            {
            }).Count);

            Assert.Null(solution.Merge(null));
        }


        [Fact]
        public void FindFirstandLastPositionofElementinSortedArrayProblemTest()
        {
            var solution = new FindFirstandLastPositionofElementinSortedArrayProblem();
            //Assert.Equal(new int[] { 1, 1}, solution.SearchRange(new int[] { 4, 5, 6, 7, 8, 1, 2 }, 5));
            //Assert.Equal(new int[] { 3, 4}, solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8));
            //Assert.Equal(new int[] { -1, -1}, solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6));
            //Assert.Equal(new int[] { 0, 0}, solution.SearchRange(new int[] { 5 }, 5));
            //Assert.Equal(new int[] { -1, -1}, solution.SearchRange(new int[] { 0 }, 5));
            //Assert.Equal(new int[] { -1, -1}, solution.SearchRange(new int[] { }, 5));
            //Assert.Equal(new int[] { 0, 4}, solution.SearchRange(new int[] { 5,5,5,5,5 }, 5));
        }


        [Fact]
        public void JumpGameProblemTest()
        {
            var solution = new JumpGameProblem();
            Assert.True(solution.CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Assert.False(solution.CanJump(new int[] { 3, 2, 1, 0, 4 }));
            Assert.False(solution.CanJump(new int[] { 0, 2, 1, 0, 4 }));
            Assert.True(solution.CanJump(new int[] { 2, 0 }));
        }

        [Fact]
        public void SpiralMatrixProblemTest()
        {
            var solution = new SpiralMatrixProblem();

            var matrix = new int[,] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };

            Helperrs.PrintMatrix(matrix);
            var result = solution.SpiralOrder(matrix);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, result);
            Helperrs.PrintArray(result);

            matrix = new int[,] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };
            Helperrs.PrintMatrix(matrix);
            result = solution.SpiralOrder(matrix);
            Helperrs.PrintArray(result);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, result);

            matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            Helperrs.PrintMatrix(matrix);
            result = solution.SpiralOrder(matrix);
            Helperrs.PrintArray(result);
            Assert.Equal(new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, result);
        }

        [Fact]
        public void LongestIncreasingSubsequenceProblemTest()
        {
            var solution = new LongestIncreasingSubsequenceProblem();

            Assert.Equal(4, solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }));
            Assert.Equal(3, solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 4 }));
            Assert.Equal(1, solution.LengthOfLIS(new int[] { 10 }));
            Assert.Equal(3, solution.LengthOfLIS(new int[] { 4, 10, 4, 3, 8, 9 }));
        }


        [Fact]
        public void WordSearchProblemTest()
        {
            var solution = new WordSearchProblem();

            Assert.True(solution.Exist(new char[,] { { 'A', 'B', 'C', 'E' }, { 'S', 'F', 'C', 'S' }, { 'A', 'D', 'E', 'E' } }, "ABCCED"));
            Assert.True(solution.Exist(new char[,] { { 'A', 'B', 'C', 'E' }, { 'S', 'F', 'C', 'S' }, { 'A', 'D', 'E', 'E' } }, "SEE"));
            Assert.False(solution.Exist(new char[,] { { 'A', 'B', 'C', 'E' }, { 'S', 'F', 'C', 'S' }, { 'A', 'D', 'E', 'E' } }, "ABCB"));
            Assert.True(solution.Exist(new char[,] { { 'a', 'b' }, { 'c', 'd' } }, "cdba"));
            Assert.True(solution.Exist(new char[,] { { 'A', 'B', 'C', 'E' }, { 'S', 'F', 'E', 'S' }, { 'A', 'D', 'E', 'E' } }, "ABCESEEEFS"));
        }

        [Fact]
        public void SortColorsProblemsTest()
        {
            var solution = new SortColorsProblems();
            var input = new int[] { 2, 0, 2, 1, 1, 0 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 0, 1, 1, 2, 2 }, input);

            input = new int[] { 2, 0, 2, 0 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 0, 2, 2 }, input);

            input = new int[] { 1, 0, 1, 0 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 0, 1, 1 }, input);

            input = new int[] { 1, 0, };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 1 }, input);

            input = new int[] { 0, 0 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 0 }, input);

            input = new int[] { 0, 2 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 2 }, input);

            input = new int[] { 0, 2, 1 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 1, 2 }, input);

            input = new int[] { 0, 2, 1, 1 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 1, 1, 2 }, input);

            input = new int[] { 2, 2 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 2, 2 }, input);

            input = new int[] { 1, 1 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 1, 1 }, input);

            input = new int[] { 2, 0, 2 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 2, 2 }, input);

            input = new int[] { 0, 2, 2, 2, 0, 2, 1, 1 };
            solution.SortColors(input);
            Assert.Equal(new int[] { 0, 0, 1, 1, 2, 2, 2, 2 }, input);
        }

        [Fact]
        public void ThreeSumProblemTest()
        {
            var solution = new ThreeSumProblem();
            Assert.Equal(new List<IList<int>> { new List<int>() { -1, -1, 2 }, new List<int>() { -1, 0, 1 } },
                solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
        }

        [Fact]
        public void KthSmallestElementinaBSTProblemTest()
        {
            var solution = new KthSmallestElementinaBSTProblem();
            var root = new TreeNode(3)
            {
                left = new TreeNode(1)
                {
                    right = new TreeNode(2)
                },
                right = new TreeNode(4)
            };
            Assert.Equal(1, solution.KthSmallest(root, 1));

            root = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2)
                    {
                        left = new TreeNode(1) { }
                    },
                    right = new TreeNode(4)
                },
                right = new TreeNode(6) { }
            };
            Assert.Equal(3, solution.KthSmallest(root, 3));
        }

        [Fact]
        public void FourSumIIProblemTest()
        {
            var solution = new FourSumIIProblem();
            Assert.Equal(2, solution.FourSumCount(new int[] { 1, 2 }
            , new int[] { -2, -1 }
            , new int[] { -1, 2 }
            , new int[] { 0, 2 }
            ));
        }

        [Fact]
        public void KthSmallestElementinaSortedMatrixProblemTest()
        {
            var solution = new KthSmallestElementinaSortedMatrixProblem();
            Assert.Equal(13, solution.KthSmallest(new int[][] { new int[] { 1, 5, 9 }, new int[] { 10, 11, 13 }, new int[] { 12, 13, 15 } }, 8));
        }
    }
}
