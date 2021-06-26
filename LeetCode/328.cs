using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _328//奇偶链表
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head==null||head.next==null)
                return head;
            ListNode odd = head;//奇数
            ListNode evenHead = head.next;//偶数链头
            ListNode even = evenHead;
            while (even!=null&&even.next!=null)
            {
                odd.next = even.next;
                even.next = even.next.next;
                even = even.next;
                odd = odd.next;
            }
            odd.next = evenHead;
            return head;


        }
    }
}
