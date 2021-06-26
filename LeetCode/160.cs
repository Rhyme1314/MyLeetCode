using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _160//相交链表
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = 0;
            int lenB = 0;
            ListNode curNode = headA;
            while (curNode!=null)
            {
                curNode = curNode.next;
                lenA++;
            }
            curNode = headB;
            while (curNode != null)
            {
                curNode = curNode.next;
                lenB++;
            }
            if (lenA>lenB)
            {
                for (int i = 0; i < lenA-lenB; i++)
                    headA = headA.next;
            }
            else
            {
                for (int i = 0; i < lenB - lenA; i++)
                    headB = headB.next;
            }
            while (headA != null)
            {
                if (headA == headB)
                    return headA;
                headA = headA.next;
                headB = headB.next;
            }
            return null;
        }
    }
}
