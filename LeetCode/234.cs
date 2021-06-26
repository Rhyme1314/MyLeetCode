using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _234// 回文链表
    {
        public bool IsPalindrome(ListNode head)
        {
            #region 暴力解法
            //if (head == null && head.next == null)
            //{
            //    return false;
            //}
            //List<int> list = new List<int>();
            //while (head != null)
            //{
            //    list.Add(head.val);
            //    head = head.next;
            //}
            //int left = 0; int right = list.Count - 1;
            //while (right >= left)
            //{
            //    if (list[left] == list[right])
            //    {
            //        left++; right--;
            //    }
            //    else return false;
            //}
            //return true;
            #endregion
            #region 快慢指针
            ListNode slow = new ListNode(0, head);
            ListNode fast = new ListNode(0, head);
            while (fast.next!=null&&fast.next.next!=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow= reverseLink(slow.next);//反转slow之后的链表
            ListNode curNode = head;
            while (slow!=null)
            {
                if (curNode.val == slow.val)
                {
                    curNode = curNode.next;
                    slow = slow.next;
                }
                else return false;
            }
            return true;
            #endregion

        }
        private ListNode reverseLink(ListNode head)
        {
            ListNode preNode = new ListNode (0,head);
            ListNode curNode = head.next;
            while (curNode!=null)
            {
                head.next = curNode.next;
                curNode.next = preNode.next;
                preNode.next = curNode;
                curNode = head.next;
            }
            return preNode.next;
        }
    }
}
