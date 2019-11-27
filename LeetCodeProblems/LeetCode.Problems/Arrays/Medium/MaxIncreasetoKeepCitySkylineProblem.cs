using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
	public class MaxIncreasetoKeepCitySkylineProblem
	{
		public int MaxIncreaseKeepingSkyline(int[][] grid)
		{
			var maxColumn = new int[grid[0].Length];
			var maxRow = new int[grid.Length];

			for (int i = 0; i < grid.Length; i++)
			{
				var maxRowElement = 0;
				for (int j = 0; j < grid[0].Length; j++)
				{
					maxRowElement = System.Math.Max(maxRowElement, grid[i][j]);
				}
				maxRow[i] = maxRowElement;
			}

			for (int i = 0; i < grid[0].Length; i++)
			{
				var maxColElement = 0;
				for (int j = 0; j < grid.Length; j++)
				{
					maxColElement = System.Math.Max(maxColElement, grid[j][i]);
				}
				maxColumn[i] = maxColElement;
			}

			var increaseCount = 0;

			for (int i = 0; i < grid.Length; i++)
			{
				for (int j = 0; j < grid[0].Length; j++)
				{
					var max = System.Math.Min(maxColumn[j], maxRow[i]);
					increaseCount += max - grid[i][j];
				}
			}

			return increaseCount;
		}
	}
}
