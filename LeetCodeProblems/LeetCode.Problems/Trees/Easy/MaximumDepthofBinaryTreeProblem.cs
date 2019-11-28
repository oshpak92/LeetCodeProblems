using LeetCode.Problems.Arrays.Medium;

namespace LeetCode.Problems.Trees.Easy
{
	public class MaximumDepthofBinaryTreeProblem
	{
		public int MaxDepth(TreeNode root)
		{
			if (root == null)
				return 0;

			return 1 + System.Math.Max(MaxDepth(root.left), MaxDepth(root.right));
		}
	}
}
