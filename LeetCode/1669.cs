using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1669//合并两个链表
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode left = new ListNode(0, list1);
            ListNode right = new ListNode(0, list1);
            ListNode list2End = new ListNode(0,list2);
            while (list2End.next!=null)
                list2End = list2End.next;
            for (int i = 0; i < a; i++)
            {
                left = left.next;
            }
            for (int i = 0; i <= b; i++)
            {
                right = right.next;
            }
            left.next = list2;
            list2End.next = right.next;
            return list1;
        }
    }
}
