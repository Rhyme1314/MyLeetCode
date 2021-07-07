using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _25//K 个一组翻转链表
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummyHead = new ListNode(0, head);
            ListNode curhead = new ListNode(0, head);
            bool isFirst = true;
            while (true)
            {
                ListNode curEnd = curhead.next;
                for (int i = 0; i < k; i++)
                {
                    if (curEnd == null) return dummyHead.next;
                    curEnd = curEnd.next;
                }
                ListNode curNode = head.next;
                while (curNode != curEnd)//翻转完了一组
                {
                    head.next = curNode.next;
                    curNode.next = curhead.next;
                    curhead.next = curNode;
                    curNode = head.next;
                }
                if (isFirst)
                {
                    dummyHead.next = curhead.next;
                    isFirst = false;
                }
                curhead = head;
                head = head.next;
            }
        }
    }
}
