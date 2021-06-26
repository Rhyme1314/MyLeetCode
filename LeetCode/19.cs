using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _19//删除链表的倒数第 N 个结点
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next==null)
                return null;
            ListNode curNode = new ListNode ();
            ListNode fastNode = new ListNode();
            curNode.next = head;
            fastNode.next= head;
            for (int i = 0; i < n; i++)
            {
                fastNode = fastNode.next;
            }
            while (fastNode.next!=null)
            {
                curNode = curNode.next;
                fastNode = fastNode.next;
            }
            if (curNode.next==head)
            {
                head = head.next;
            }
            else curNode.next = curNode.next.next;
            return head;

        }
    }
}
