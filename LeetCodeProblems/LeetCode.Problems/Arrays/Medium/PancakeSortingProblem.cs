using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 969. Pancake Sorting
    /// https://leetcode.com/problems/pancake-sorting/
    /// Runtime: 292 ms, faster than 73.81% of C# online submissions for Pancake Sorting.
    /// </summary>
    public class PancakeSortingProblem
    {
        public IList<int> PancakeSort(int[] A)
        {
            var result = new List<int>();

            var reverceLength = A.Length - 1;
            while (reverceLength != 0)
            {
                var maxIndex = FindMaxElIndex(A.Take(reverceLength+1).ToArray());
                if(maxIndex != reverceLength)
                {
                    Flip(A, maxIndex);
                    Flip(A, reverceLength);
                    if (maxIndex != 0)
                        result.Add(maxIndex + 1);
                    if (reverceLength != 0)
                        result.Add(reverceLength + 1);
                }

                reverceLength--;
            }

            return result;
        }

        public bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }

            return true;
        }

        public int FindMaxElIndex(int [] arr)
        {
            int result = 0;
            var max = arr[result];

            for(var i=0; i< arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    result = i;
                }
            }

            return result;
        }

        public int[] Flip(int [] arr, int i)
        {
            var start = 0;
            while (start < i)
            {
                var tmp = arr[start];
                arr[start] = arr[i];
                arr[i] = tmp;
                start++;
                i--;
            }
            return arr;
        }
    }
}
