using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LeetCode.Problems.LinkedList;

namespace LeetCode.Problems.Tests.LinkedList
{
    public partial class LinkedListTests
    {
        [Fact]
        public void LinkedListCycleProblemTest()
        {
            var solution = new LinkedListCycleProblem();
            var secondNode = new ListNode(2);

            var thirdNode = new ListNode(3)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5) { next = secondNode}
                }
            };
            secondNode.next = thirdNode;

            var head = new ListNode(1)
            {
                next = secondNode
            };

            Assert.True(solution.HasCycle(head));

            head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            Assert.False(solution.HasCycle(head));
            head = new ListNode(1);
            Assert.False(solution.HasCycle(head));
            Assert.False(solution.HasCycle(null));
        }

        [Fact]
        public void PalindromeLinkedListProblemTest()
        {
            var solution = new PalindromeLinkedListProblem();
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                    }
                }
            };
            Assert.True(solution.IsPalindrome(head));
            head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            Assert.False(solution.IsPalindrome(head));
            Assert.False(solution.IsPalindrome(null));

            head = new ListNode(1);
            Assert.True(solution.IsPalindrome(head));

            head = new ListNode(1)
            {
                next = new ListNode(2)
            };
            Assert.False(solution.IsPalindrome(head));
        }
    }
}
