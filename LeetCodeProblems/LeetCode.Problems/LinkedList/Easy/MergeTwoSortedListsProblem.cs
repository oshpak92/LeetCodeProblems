using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.LinkedList.Easy
{
    public class MergeTwoSortedListsProblem
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode top = null;
            ListNode iterator = null;
            while (l1 != null || l2 != null)
            {
                ListNode tmp = null;

                if (l1 == null)
                {
                    tmp = l2;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    tmp = l1;
                    l1 = l1.next;
                }
                else if (l1.val <= l2.val)
                {
                    tmp = l1;
                    l1 = l1.next;
                }
                else if (l2.val < l1.val)
                {
                    tmp = l2;
                    l2 = l2.next;
                }

                if (top == null)
                {
                    top = tmp;
                }

                if (iterator == null)
                    iterator = tmp;
                else
                {
                    iterator.next = tmp;
                    iterator = iterator.next;
                }
            }
            
            return top;
        }
    }
}
