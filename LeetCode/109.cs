using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _109//有序链表转换二叉搜索树
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            return SortedListToBST(head, null);
            
        }
        private ListNode GetMid(ListNode left, ListNode right)
        {
            ListNode fast = left;
            ListNode slow =left;
            while (fast.next != right && fast.next.next != right)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
        private TreeNode SortedListToBST(ListNode left, ListNode right)
        {
            if (left == right) return null;
            ListNode mid = GetMid(left, right);
            TreeNode root = new TreeNode(mid.val);
            root.left = SortedListToBST(left, mid);
            root.right = SortedListToBST(mid.next, right);
            return root;
        }
    }
}
