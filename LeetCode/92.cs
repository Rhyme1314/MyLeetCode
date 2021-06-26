using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _92//反转链表 II
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            #region 暴力解法
            //ListNode beforeLeft = new ListNode(0, head);
            //ListNode rightNode = new ListNode(0, head);
            //for (int i = 1; i < left; i++)
            //{
            //    beforeLeft = beforeLeft.next;
            //}
            //ListNode leftNode = beforeLeft.next;
            //for (int i = 0; i < right; i++)
            //{
            //    rightNode = rightNode.next;
            //}
            //ListNode dummyRight = new ListNode(0, rightNode.next);
            //while (leftNode.next != dummyRight.next && leftNode.next != null)
            //{
            //    ListNode curNode = leftNode.next;
            //    leftNode.next = curNode.next;
            //    curNode.next = beforeLeft.next;
            //    beforeLeft.next = curNode;
            //}
            //if (left == 1)
            //    return beforeLeft.next;
            //return head;
            #endregion
            #region 优化
            ListNode beforeLeft = new ListNode(0, head);
            ListNode curNOde = new ListNode();
            for (int i = 0; i < right; i++)
            {
                if (i < left - 1)
                    beforeLeft = beforeLeft.next;
                else if(i==left-1)
                {
                    curNOde = beforeLeft.next;
                }
                else
                {
                    ListNode next = curNOde.next;
                    curNOde.next = next.next;
                    next.next = beforeLeft.next;
                    beforeLeft.next = next;
                }
            }
            return left == 1 ? beforeLeft.next : head;
            #endregion

        }
    }
}
