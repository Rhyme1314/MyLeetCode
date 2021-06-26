using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _61//旋转链表

    {
        public ListNode RotateRight(ListNode head, int k)
        {
            int len = 0;
            if (head==null)
                return null;
            ListNode lastNode = new ListNode(0, head);
            while (lastNode.next!=null)
            {
                lastNode = lastNode.next;
                len++;
            }
            lastNode.next = head;
            ListNode newhead = new ListNode(0, head);
            for (int i = 0; i < len-(k%len); i++)
                newhead = newhead.next;
            ListNode resHead = newhead.next;
            newhead.next = null;
            return resHead;
        }
    }
}
