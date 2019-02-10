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
            Assert.Equal(8, solution.MyPow(2, 3));
            Assert.Equal(1024, solution.MyPow(2, 10));
            Assert.Equal(0.25, solution.MyPow(2, -2));
            Assert.Equal(1, solution.MyPow(2, 0));
            Assert.Equal(1, solution.MyPow(0.00001, 2147483647));
            Assert.Equal(1, solution.MyPow(1.0, -2147483648));
        }

        [Fact]
        public void FractiontoRecurringDecimalProblemTest()
        {
            var solution = new FractiontoRecurringDecimalProblem();
            Assert.Equal("0.5", solution.FractionToDecimal(1, 2));
            Assert.Equal("2", solution.FractionToDecimal(2, 1));
            Assert.Equal("0.(6)", solution.FractionToDecimal(2, 3));
            Assert.Equal("0", solution.FractionToDecimal(0, 3));
            Assert.Equal("1", solution.FractionToDecimal(int.MaxValue, int.MaxValue));
            Assert.Equal("1", solution.FractionToDecimal(int.MinValue, int.MinValue));
            Assert.Equal("2", solution.FractionToDecimal(10, 5));
            Assert.Equal("0.(012)", solution.FractionToDecimal(4, 333));
            Assert.Equal("0.1(6)", solution.FractionToDecimal(1, 6));
            Assert.Equal("-6.25", solution.FractionToDecimal(-50, 8));
            Assert.Equal("-0.58(3)", solution.FractionToDecimal(7, -12));
        }

        [Fact]
        public void DivideTwoIntegersProblemTest()
        {
            var solution = new DivideTwoIntegersProblem();
            Assert.Equal(3, solution.Divide(7, 2));
            Assert.Equal(-3, solution.Divide(-7, 2));
            Assert.Equal(3, solution.Divide(-7, -2));
            Assert.Equal(2147483647, solution.Divide(-2147483648, -1));
        }

        [Fact]
        public void StringtoIntegerAtoiProblemTest()
        {
            var solution = new StringtoIntegerAtoiProblem();
            Assert.Equal(42, solution.MyAtoi("42"));
            Assert.Equal(-42, solution.MyAtoi("   -42"));
            Assert.Equal(4193, solution.MyAtoi("4193 with words"));
            Assert.Equal(0, solution.MyAtoi("words and 987"));
            Assert.Equal(-2147483648, solution.MyAtoi("-91283472332"));
            Assert.Equal(0, solution.MyAtoi("-0"));
            Assert.Equal(-1, solution.MyAtoi("-1"));
            Assert.Equal(1, solution.MyAtoi("+1"));
            Assert.Equal(2147483647, solution.MyAtoi("2147483647"));
            Assert.Equal(2147483647, solution.MyAtoi("2147483648"));
            Assert.Equal(-2147483648, solution.MyAtoi("-2147483648"));
            Assert.Equal(0, solution.MyAtoi("-"));
            Assert.Equal(0, solution.MyAtoi("   "));
            Assert.Equal(12345678, solution.MyAtoi("  0000000000012345678"));
            Assert.Equal(0, solution.MyAtoi("  00000000000"));
            Assert.Equal(2147483647, solution.MyAtoi("2147483800"));
        }

    }
}
