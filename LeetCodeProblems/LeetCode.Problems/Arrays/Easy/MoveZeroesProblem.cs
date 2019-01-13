using LeetCode.Problems.Utils;

namespace LeetCode.Problems.Arrays.Easy
{
    /// <summary>
    /// 283. Move Zeroes
    /// https://leetcode.com/problems/move-zeroes/
    /// Runtime: 296 ms, faster than 78.95% of C# online submissions for Move Zeroes.
    /// </summary>
    public class MoveZeroesProblem
    {
        public void MoveZeroes(int[] nums)
        {
            int zerosCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zerosCount++;
                }
                else
                {
                    nums[i - zerosCount] = nums[i];
                }
            }
            while (zerosCount > 0)
            {
                nums[nums.Length - zerosCount--] = 0;
            }
        }


        //Runtime: 316 ms, faster than 44.21% of C# online submissions for Move Zeroes.
        //public void MoveZeroes(int[] nums)
        //{
        //    var shiftIndex = nums.Length - 1;
        //    var current = 0;

        //    while (shiftIndex != current)
        //    {
        //        if (nums[shiftIndex] == 0)
        //        {
        //            shiftIndex--;
        //        }
        //        else if (nums[current] == 0)
        //        {
        //            Shift(nums, current, shiftIndex);
        //            shiftIndex--;
        //        }
        //        else
        //        {
        //            current++;
        //        }
        //    }
        //}

        //public int[] Shift(int[] arr, int startIndex, int lastIndex)
        //{
        //    for (var i = startIndex; i < lastIndex; i++)
        //    {
        //        var tmp = arr[i];
        //        arr[i] = arr[i + 1];
        //        arr[i + 1] = tmp;
        //    }

        //    return arr;
        //}
    }
}
