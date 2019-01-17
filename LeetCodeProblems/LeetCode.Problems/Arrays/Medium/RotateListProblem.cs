using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 61. Rotate List
    /// https://leetcode.com/problems/rotate-list/
    /// Runtime: 112 ms, faster than 80.00% of C# online submissions for Rotate List.
    /// </summary>
    public class RotateListProblem
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            var length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            k = k - (k / length) * length;

            while (k > 0)
            {
                head = Step(head.next, head, head);
                k--;
            }
            return head;
        }

        public ListNode Step(ListNode node, ListNode prev, ListNode head)
        {
            if (node == null) return null;
            if(node.next == null)
            {
                prev.next = null;
                node.next = head;
                return node;
            }
            return Step(node.next, node, head);
        }
    }
}
