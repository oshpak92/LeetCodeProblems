using LeetCode.Problems.Arrays.Easy;
using LeetCode.Problems.Arrays.Medium;
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

        [Fact]
        public void ProductofArrayExceptSelfProblemTest()
        {
            var solution = new ProductofArrayExceptSelfProblem();
            Assert.Equal(new int[] { 24, 12, 8, 6 }, solution.ProductExceptSelf(new int[] { 1, 2, 3, 4 }));
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
    }
}
