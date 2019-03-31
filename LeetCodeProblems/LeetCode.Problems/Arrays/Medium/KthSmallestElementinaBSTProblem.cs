using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    /// <summary>
    /// 230. Kth Smallest Element in a BST
    /// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    /// </summary>
    public class KthSmallestElementinaBSTProblem
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
                return -1;

            var inorder = new List<int>();
            InOrderTraversar(root, inorder);
            inorder.Sort();

            return inorder[k-1];
        }

        private void InOrderTraversar(TreeNode root, List<int> inorder)
        {
            if (root == null)
                return;

            if (root.left != null)
                InOrderTraversar(root.left, inorder);

            inorder.Add(root.val);

            InOrderTraversar(root.right, inorder);
        }
    }
}
