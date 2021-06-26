using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        } 
    }


    class _203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            #region 先判断头节点是否需要删除
            //if (head == null) return head;
            //while (head != null)
            //{
            //    if (head.val == val)
            //    {
            //        head = head.next;
            //    }
            //    else break;
            //}
            //ListNode pre = new ListNode (0,head);
            //ListNode cur = head;
            //while (cur != null)
            //{
            //    if (cur.val != val)
            //    {
            //        pre = cur;
            //        cur = cur.next;
            //    }
            //    else if (cur.val == val)
            //    {
            //        pre.next = cur.next;
            //        cur = cur.next;
            //    }
            //}
            //return head;
            #endregion
            #region 虚拟头节点
            ListNode dummyHead = new ListNode(val-1, head);
            ListNode pre = dummyHead;
            while (pre.next!=null)
            {
                if (pre.next.val == val)
                {
                    pre.next = pre.next.next;
                }
                else pre = pre.next;
            }
            return dummyHead.next;
            #endregion


        }
    }
}
