using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _24// 两两交换链表中的节点
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head==null||head.next==null)
                return head;
            ListNode dummyHead = new ListNode(0, head.next);
            ListNode pre = new ListNode(0, head);
            ListNode l = head;
            ListNode r = head.next;
            while (r!=null)
            {
                l.next = r.next;
                r.next = l;
                pre.next = r;
                pre = l;
                l = l.next;
                if (l==null)
                    break;
                r = l.next;
            }
            return dummyHead.next;


        }
    }
}
