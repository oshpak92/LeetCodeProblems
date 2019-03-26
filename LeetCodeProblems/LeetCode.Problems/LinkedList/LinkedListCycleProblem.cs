using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.LinkedList
{
    /// <summary>
    /// 141. Linked List Cycle
    /// https://leetcode.com/problems/linked-list-cycle/
    /// Runtime: 96 ms, faster than 97.97% of C# online submissions for Linked List Cycle.
    /// Memory Usage: 23.7 MB, less than 36.49% of C# online submissions for Linked List Cycle.
    /// </summary>
    public class LinkedListCycleProblem
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            
            var tortoize = head;
            var hare = head.next?.next;
            while (tortoize != null && hare != null )
            {
                if(tortoize == hare)
                    return true;

                tortoize = tortoize.next;
                hare = hare.next?.next;
            }

            return false;
        }
    }
}
