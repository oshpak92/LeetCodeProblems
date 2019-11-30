using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.LinkedList.Easy
{
	//0 -> 1 -> 2 -> 3 -> null
	//3 -> 2 -> 1 -> 0
	public class ReverseLinkedListProblem
	{
		public ListNode ReverseList(ListNode head)
		{
			var reversedHead = Reverse(head, null);
			head.next = null;
			return reversedHead;
		}

		private ListNode Reverse(ListNode node, ListNode previousNode)
		{
			if (node == null)
				return null;

			if (node.next == null)
			{
				node.next = previousNode;
				return node;
			}
			
			var head = Reverse(node.next, node);

			if(previousNode != null)
				node.next = previousNode;
			else
				node.next = null;
			
			return head;
		}
	}

}
