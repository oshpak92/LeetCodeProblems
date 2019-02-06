using LeetCode.Problems.Math.Easy;
using LeetCode.Problems.Math.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static LeetCode.Problems.Math.Medium.AddTwoNumbersProblem;

namespace LeetCode.Problems.Tests.Math.Medium
{
    public class MathTests
    {
        [Fact]
        public void PerfectSquaresProblemTest()
        {
            var solution = new PerfectSquaresProblem();
            Assert.Equal(3, solution.NumSquares(12));
        }

        [Fact]
        public void AddTwoNumbersProblemTest()
        {
            //342
            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            //465
            var l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var solution = new AddTwoNumbersProblem();
            var result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(7, result.val);
            Assert.Equal(0, result.next.val);
            Assert.Equal(8, result.next.next.val);
            Assert.Null(result.next.next.next);

            //342
            l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            //465
            l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(9)
                    }
                }
            };

            result = solution.AddTwoNumbers(l1, l2);
            Assert.Equal(7, result.val);
            Assert.Equal(0, result.next.val);
            Assert.Equal(8, result.next.next.val);
            Assert.Equal(9, result.next.next.next.val);
            Assert.Null(result.next.next.next.next);
        }

        [Fact]
        public void PowProblemTest()
        {
            var solution = new PowProblem();
            //Assert.Equal(8, solution.MyPow(2, 3));
            //Assert.Equal(1024, solution.MyPow(2, 10));
            //Assert.Equal(0.25, solution.MyPow(2, -2));
            //Assert.Equal(1, solution.MyPow(2, 0));
            //Assert.Equal(1, solution.MyPow(0.00001, 2147483647));
            Assert.Equal(1, solution.MyPow(1.0, -2147483648));
        }

    }
}
