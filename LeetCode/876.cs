using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _876//链表的中间结点
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head.next;
            ListNode slow = head.next;
            while (fast.next!=null&&fast.next.next!=null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if (fast.next == null)
            {
                return slow;
            }
            else return slow.next;
        }
    }
}
