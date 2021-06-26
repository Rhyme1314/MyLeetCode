using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _147//对链表进行插入排序
    {
        public ListNode SortList(ListNode head)
        {
            ListNode dummyhead = new ListNode(0, head);
            ListNode curNode = head.next;
            ListNode pre = head;
            while (curNode != null)
            {
                ListNode newNode = dummyhead.next;
                ListNode newPre = dummyhead;
                while (curNode.val > newNode.val)
                {
                    newPre = newNode;
                    newNode = newNode.next;
                    if (newPre == pre)
                        break;
                }
                if (newPre == pre)
                {
                    curNode = curNode.next;
                    pre = pre.next;
                    continue;
                }
                pre.next = curNode.next;//删除curNode
                curNode.next = newPre.next;
                newPre.next = curNode;
                curNode = pre.next;
            }

            return dummyhead.next;
        }
    }
}
