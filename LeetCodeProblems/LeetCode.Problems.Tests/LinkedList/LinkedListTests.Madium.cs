using LeetCode.Problems.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Problems.Tests.LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void RemoveNthNodeFromEndofListProblemTest()
        {
            var solution = new RemoveNthNodeFromEndofListProblem();
            var head = new ListNode(1)
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

            var result = solution.RemoveNthFromEnd(head, 2);
            
            while(result.next != null)
            {
                Assert.NotEqual(4, result.val);
                result = result.next;
            }

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

            result = solution.RemoveNthFromEnd(head, 1);

            while (result.next != null)
            {
                Assert.NotEqual(5, result.val);
                result = result.next;
            }

            head = new ListNode(1)
            {
               val = 1
            };

            result = solution.RemoveNthFromEnd(head, 1);
            Assert.Null(result);
        }
    }
}
