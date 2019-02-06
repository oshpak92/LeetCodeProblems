using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Math.Medium
{
    /// <summary>
    /// 2. Add Two Numbers
    /// https://leetcode.com/problems/add-two-numbers/
    /// Runtime: 132 ms, faster than 81.49% of C# online submissions for Add Two Numbers.
    /// Memory Usage: 12.9 MB, less than 43.55% of C# online submissions for Add Two Numbers.
    /// </summary>
    public class AddTwoNumbersProblem
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Rec(l1, l2, 0);
        }

        private ListNode Rec(ListNode l1, ListNode l2, int corelation)
        {
            if (l1 == null && l2 == null && corelation == 0)
                return null;
            else if (l1 == null && l2 == null && corelation != 0)
                return new ListNode(corelation);

            var val = (l1?.val ?? 0) + (l2?.val ?? 0) + corelation;
            var node = new ListNode(val % 10);
            node.next = Rec(l1?.next, l2?.next, val / 10);
            return node;
        }
    }
}
