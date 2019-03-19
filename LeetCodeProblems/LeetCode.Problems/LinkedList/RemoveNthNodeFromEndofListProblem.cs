using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.LinkedList
{
    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    /// <summary>
    /// 19. Remove Nth Node From End of List
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// Maintain two pointers and update one with a delay of n steps.
    /// </summary>
    public class RemoveNthNodeFromEndofListProblem
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var current = head;
            var i = 0;
            ListNode nodeToDelete = null;

            while (current.next != null)
            {
                if (i + 1 == n)
                    nodeToDelete = head;
                else if (nodeToDelete != null)
                    nodeToDelete = nodeToDelete.next;

                current = current.next;
                i++;
            }
            if (nodeToDelete == null)
                head = head.next;
            else if (nodeToDelete != null)
                nodeToDelete.next = nodeToDelete.next?.next;

            return head;
        }
    }
}
