using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _2//两数相加
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Add(l1, l2, 0);
        }
        private ListNode Add(ListNode curLeft, ListNode curRight, int extra)
        {
            ListNode curNode = new ListNode();
            if (curLeft == null && curRight == null)
            {
                curNode.val = extra;
                if (extra == 0)
                    return null;
                else
                    return curNode;
            }
            else if (curRight == null)
            {
                curNode.val = curLeft.val + extra;
                int n = curNode.val / 10;
                curNode.val %= 10;
                curNode.next = Add(curLeft.next, null, n);
            }
            else if (curLeft == null)
            {
                curNode.val = curRight.val + extra;
                int n = curNode.val / 10;
                curNode.val %= 10;
                curNode.next = Add(null, curRight.next, n);
            }
            else
            {
                curNode.val = curLeft.val + curRight.val + extra;
                int n = curNode.val / 10;
                curNode.val %= 10;
                curNode.next = Add(curLeft.next, curRight.next, n);
            }
            return curNode;
        }
    }
}
