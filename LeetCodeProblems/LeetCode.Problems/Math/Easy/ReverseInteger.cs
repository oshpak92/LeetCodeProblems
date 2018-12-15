using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var result = 0;
            while (x != 0)
            {
                var pop = x % 10;
                x /= 10;

                //check for stack overflow exceptions
                if (int.MaxValue / 10 < result || (result == int.MaxValue / 10) && pop > 7) return 0;
                if (int.MinValue / 10 > result || (result == int.MinValue / 10) && pop < -8) return 0;

                result = result * 10 + pop;
            }

            return result;
        }
    }
}
