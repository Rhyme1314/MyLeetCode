using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _141
    {
        public bool HasCycle(ListNode head)
        {
            #region 快慢指针判断链表是否有环
            ListNode fast = new ListNode(0, head);
            ListNode slow = new ListNode(0, head);
            if (head == null || head.next == null || head.next.next == null)
                return false;
            if (head.next == head)
                return true;
            while (fast!= null && fast.next != null) 
            {
                if (fast.Equals(slow))
                    return true;
                fast = fast.next.next;
                slow = slow.next;
            } 
            return false;
            #endregion
            #region hash集合 需要额外开一个N的空间建立hash集合
            //HashSet<ListNode> set = new HashSet<ListNode>();
            //ListNode cur = new ListNode(0, head);
            //if (head==null)
            //    return false;
            //while (cur != null)
            //{
            //    if (set.Contains(cur))
            //        return true;
            //    else
            //        set.Add(cur);
            //    cur = cur.next;

            //}
            //return false;
            #endregion

        }
    }
}
