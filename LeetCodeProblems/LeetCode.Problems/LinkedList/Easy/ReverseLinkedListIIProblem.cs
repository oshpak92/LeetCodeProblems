using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCode.Problems.LinkedList.Easy
{
	/// <summary>
	/// 92. Reverse Linked List II
	/// </summary>
	public class ReverseLinkedListIIProblem
	{
		//O(n)
		public ListNode ReverseBetween(ListNode head, int m, int n)
		{
			var current = head;
			ListNode reversePoint = null;

			while (m != 1)
			{
				m--; n--;
				reversePoint = current;
				current = current.next;
			}
			var reversed = Reverse(current, n);

			if (reversePoint != null)
				reversePoint.next = reversed;
			else
				head = reversed;

			return head;
		}

		private ListNode Reverse(ListNode head, int count)
		{
			var current = head;
			ListNode rootNode = head;
			while (count > 0)
			{
				var tmp = current.next;
				current.next = rootNode;
				rootNode = current;
				current = tmp;
				count--;
			}
			head.next = current;
			return rootNode;
		}
	}
}
