using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 105. Construct Binary Tree from Preorder and Inorder Traversal
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/submissions/
    /// Runtime: 128 ms, faster than 57.14% of C# online submissions for Construct Binary Tree from Preorder and Inorder Traversal.
    /// From discussions....
    /// </summary>
    public class ConstructBinaryTreefromPreorderandInorderTraversalProblem
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return helper(0, 0, inorder.Length - 1, preorder, inorder);
        }

        public TreeNode helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
        {
            if (preStart > preorder.Length - 1 || inStart > inEnd)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[preStart]);
            int inIndex = 0; // Index of current root in inorder
            for (int i = inStart; i <= inEnd; i++)
            {
                if (inorder[i] == root.val)
                {
                    inIndex = i;
                }
            }
            root.left = helper(preStart + 1, inStart, inIndex - 1, preorder, inorder);
            root.right = helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorder);
            return root;
        }
    }
}
