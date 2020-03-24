using LeetCode.Problems.Arrays.Medium;

namespace LeetCode.Problems.Trees.Easy
{
    public class ConvertSortedArraytoBinarySearchTreeProblem
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            return BuildSubTree(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildSubTree(int[] nums, int left, int right)
        {
            if (left == right)
                return new TreeNode(nums[left]);

            //only 2 nodes left ?
            if (right - left == 1)
            {
                return new TreeNode(System.Math.Max(nums[left], nums[right]))
                {
                    left = new TreeNode(System.Math.Min(nums[left], nums[right]))
                };
            }

            var mid = (right + left) / 2;
            var root = new TreeNode(nums[mid]);
            root.left = BuildSubTree(nums, left, mid - 1);
            root.right = BuildSubTree(nums, mid + 1, right);

            return root;
        }
    }
}
