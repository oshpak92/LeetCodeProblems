using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 29. Divide Two Integers
    /// https://leetcode.com/problems/divide-two-integers/
    /// Runtime: 48 ms, faster than 95.63% of C# online submissions for Divide Two Integers.
    /// Memory Usage: 4.8 MB, less than 59.26% of C# online submissions for Divide Two Integers.
    /// </summary>
    public class DivideTwoIntegersProblem
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
                return 0;
            var sign = (dividend < 0 && divisor >= 0) || (dividend >= 0 && divisor < 0) ? -1 : 1;

            //case 1: dividend > 0, divisor > 0
            //case 2: dividend > 1, divisor < 0
            //case 3: dividend < 1, divisor > 0
            //case 4: dividend < 1, divisor < 0
            var result = divide(System.Math.Abs((long)dividend), System.Math.Abs((long)divisor)) * sign;
            if (result < int.MinValue)
                return int.MinValue;
            else if (result > int.MaxValue)
                return int.MaxValue;

            return (int)result ;
        }

        private long divide(long dividend, long divisor)
        {
            if (dividend < divisor)
                return 0;
            if (divisor == 1)
                return dividend;
            if (dividend == 1)
                return 0;

            var counter = 1;
            var sum = divisor;

            // start from 1
            // looking for the number = dividend / 2
            while (dividend - sum >= sum)
            {
                sum += sum;
                counter += counter;
            }

            return counter + divide(dividend - sum, divisor);
        }

        //private bool IsCompleted(int dividend, int divisor)
        //{
        //    if (dividend > 0 && divisor > 0)
        //    {
        //        if (dividend < divisor)
        //            return true;
        //    }
        //    else if (dividend < 0 && divisor > 0)
        //    {
        //        if (dividend + divisor > 0)
        //            return true;
        //    }
        //    else if (dividend > 0 && divisor < 0)
        //    {
        //        if (dividend + divisor < 0)
        //            return true;
        //    }
        //    else if (dividend < 0 && divisor < 0)
        //    {
        //        if (divisor == int.MinValue)
        //        {
        //            if (divisor - dividend > 0)
        //                return true;
        //        }
        //        else
        //        {
        //            if (dividend - divisor < 0)
        //                return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
