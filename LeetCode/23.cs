using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _23//合并K个升序链表
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            int n = lists.Length;
           return Merge(lists, 0, n - 1);
        }
        public ListNode Merge(ListNode[] lists,int left,int right) {
           
            if (right-left==1)
            {
               return MergeTwoLists(lists[left], lists[right]);
            }
            if (left==right)
            {
                return lists[left];
            }
            int mid = left + (right - left) / 2;
            return  MergeTwoLists(Merge(lists, left, mid), Merge(lists, mid + 1, right));
           
           
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            #region 代码精简版
            if (l1 == null && l2 == null)
                return null;
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
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
        #region 自己写的 
        //public ListNode DiGui(ListNode[] lists, int index)
        //{
        //    lists[index] = lists[index].next;
        //    int n = lists.Length;
        //    ListNode minNode = new ListNode(int.MaxValue, null);
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (lists[i] != null)
        //        {
        //            minNode = minNode.val < lists[i].val ? minNode : lists[i];
        //            index = minNode.val < lists[i].val ? index : i;
        //        }
        //    }
        //    if (minNode.val == int.MaxValue)
        //        return null;
        //    minNode.next = DiGui(lists, index);
        //    return minNode;
        //}
        #endregion

    }
}
