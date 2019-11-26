using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Easy
{
	public class MinimumTimeVisitingAllPointsProblem
	{
		public int MinTimeToVisitAllPoints(int[][] points)
		{
			var steps = 0;
			
			for (int i = 0; i < points.Length - 1; i++)
			{
				Move(points[i], points[i + 1], ref steps);
			}

			return steps;
		}

		public int[] Move(int [] current, int[] destination, ref int stepsCounter)
		{
			if (current[0] == destination[0] && current[1] == destination[1])
			{
				//we reached the point no steps left
				return current;
			}
			current[0] = CalculateNextLocation(current[0], destination[0]);
			current[1] = CalculateNextLocation(current[1], destination[1]);
			stepsCounter++;

			return Move(current, destination, ref stepsCounter);
		}

		private int CalculateNextLocation(int current, int destination)
		{
			if (current < destination)
				current++;
			else if (current > destination)
				current--;
			return current;
		}
	}
}
