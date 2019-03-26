using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.LinkedList
{
    /// <summary>
    /// 234. Palindrome Linked List
    /// https://leetcode.com/problems/palindrome-linked-list/
    /// </summary>
    public class PalindromeLinkedListProblem
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;
            if (head.next == null)
                return true;

            var list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            int i = 0, j = 0;
            if(list.Count % 2 == 0)
            {
                i = (list.Count / 2) - 1;//[1,2,2,1]
                j = i + 1;
            }
            else
            {
                i = list.Count / 2;
                j = i;
            }
            
            for (; i >= 0 && j < list.Count; i--, j++)
            {
                if (list[i] != list[j])
                    return false;
            }

            return true;
        }
    }
}
