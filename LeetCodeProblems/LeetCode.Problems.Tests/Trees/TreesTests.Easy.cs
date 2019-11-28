using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Problems.Arrays.Medium;
using LeetCode.Problems.Trees.Easy;
using Xunit;

namespace LeetCode.Problems.Tests.Trees
{
	public partial class TreesTests
	{
		[Fact]
		public void MaximumDepthofBinaryTreeProblemTest()
		{
			var solution = new MaximumDepthofBinaryTreeProblem();
			var tree = new TreeNode(3)
			{
				left = new TreeNode(9),
				right = new TreeNode(20)
				{
					left = new TreeNode(15),
					right = new TreeNode(7)
				}
			};
			Assert.Equal(3, solution.MaxDepth(tree));
		}
	}
}
