using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.HashTable.Easy
{
	public class SingleNumberProblem
	{
		public int SingleNumber(int[] nums)
		{
			var buffer = new HashSet<int>();
			foreach (var item in nums)
			{
				if (!buffer.Contains(item))
					buffer.Add(item);
				else
					buffer.Remove(item);
			}

			return buffer.First();
		}

	}
}
