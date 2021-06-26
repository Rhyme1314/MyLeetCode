using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    class _206//反转链表
    {
        ListNode dummyhead = new ListNode();
        public ListNode ReverseList(ListNode head)
        {
            #region 虚拟头指针
            //ListNode dummyHead = new ListNode(0, head);
            //ListNode cur = head.next;
            //while (cur!=null)
            //{
            //    head.next = cur.next;
            //    cur.next = dummyHead.next;
            //    dummyHead.next = cur;
            //    cur = head.next;
            //}
            //return dummyHead.next;
            #endregion
            if (head == null) return head;
            Func(head);
            return dummyhead;
        }
        private ListNode Func(ListNode node)
        {
            if (node.next==null)
            {
                dummyhead.next = node;
                return node;
            }
            Func(node.next).next = node;
            node.next = null;
            return node;
        }
    }
}
