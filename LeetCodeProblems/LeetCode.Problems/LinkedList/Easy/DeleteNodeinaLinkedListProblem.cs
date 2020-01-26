namespace LeetCode.Problems.LinkedList.Easy
{
	public class DeleteNodeinaLinkedListProblem
	{
		public void DeleteNode(ListNode node)
		{
			if(node?.next == null)
				return;

			node.val = node.next.val;
			node.next = node.next.next;
		}
	}
}
