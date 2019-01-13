using System;

namespace LeetCode.Problems.Utils
{
    public class Helperrs
    {
        public static int [] Shift(int [] arr, int startIndex, int lastIndex)
        {
            for (var i = startIndex; i < lastIndex; i++)
            {
                var tmp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = tmp;
            }

            return arr;
        }
    }
}
