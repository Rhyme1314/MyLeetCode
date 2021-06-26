using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _21//合并两个有序链表
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            #region 自己写的暴力递归
            //if (l1 == null && l2 == null)
            //    return null;
            //ListNode curNode = new ListNode();
            //if (l1 != null && l2 != null && l1.val >= l2.val)
            //{
            //    curNode.val = l2.val;
            //    curNode.next = MergeTwoLists(l1, l2.next);
            //}
            //else if (l1 != null && l2 != null && l1.val < l2.val)
            //{
            //    curNode.val = l1.val;
            //    curNode.next = MergeTwoLists(l1.next, l2);
            //}
            //else if (l1 == null && l2 != null)
            //{
            //    curNode.val = l2.val;
            //    curNode.next = MergeTwoLists(l1, l2.next);
            //}
            //else if (l1 != null && l2 == null)
            //{
            //    curNode.val = l1.val;
            //    curNode.next = MergeTwoLists(l1.next, l2);
            //}
            //return curNode;
            #endregion
            #region 代码精简版
            if (l1 == null && l2 == null)
                return null;
            //ListNode curNode = new ListNode();
            if (l1==null)
            {
                return l2;
            }
            else if (l2==null)
            {
                return l1;
            }
            else if (l1.val<l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else 
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

            #endregion

        }
    }
}
