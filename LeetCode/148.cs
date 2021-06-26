using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _148//排序链表
    {
        ListNode newNode = new ListNode();
        public ListNode SortList(ListNode head)
        {
            #region 冒泡 超时
            //if (head == null || head.next == null)
            //{
            //    return head;
            //}
            //int len = 0;
            //ListNode curNode = head;
            //while (curNode != null)
            //{
            //    curNode = curNode.next;
            //    len++;
            //}
            //bool isBubble = true;
            //while (isBubble)
            //{
            //    curNode = head;
            //    ListNode preNode = new ListNode(0, curNode);
            //    if (head.val > head.next.val)
            //        head = head.next;
            //    isBubble = false;
            //    for (int i = 1; i < len; i++)
            //    {
            //        if (curNode.val > curNode.next.val)
            //        {
            //            preNode.next = curNode.next;
            //            curNode.next = curNode.next.next;
            //            preNode.next.next = curNode;
            //            curNode = preNode.next;
            //            isBubble = true;
            //        }
            //        curNode = curNode.next;
            //        preNode = preNode.next;
            //    }
            //}
            #endregion
            #region 插排 也超时了
            //ListNode dummyhead = new ListNode(0, head);
            //ListNode curNode = head.next;
            //ListNode pre = head;
            //while (curNode != null)
            //{
            //    ListNode newNode = dummyhead.next;
            //    ListNode newPre = dummyhead;
            //    while (curNode.val > newNode.val)
            //    {
            //        newPre = newNode;
            //        newNode = newNode.next;
            //        if (newPre == pre)
            //            break;
            //    }
            //    if (newPre == pre)
            //    {
            //        curNode = curNode.next;
            //        pre = pre.next;
            //        continue;
            //    }
            //    pre.next = curNode.next;//删除curNode
            //    curNode.next = newPre.next;
            //    newPre.next = curNode;
            //    curNode = pre.next;
            //}

            //return dummyhead.next;
            #endregion
            return head;
            

        }

        public void Sort(ListNode curHead, int len)
        {
            if (len<=1)
                return;
            ListNode fast = curHead;
            ListNode slow = curHead;
            while (fast.next!=null&&fast.next.next!=null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            Sort(slow, len / 2);
            Sort(curHead, len / 2);
            MergeSort(curHead, slow, len);
        }

        private void MergeSort(ListNode curHead, ListNode slow, int len)
        {
          
        }
    }
}
