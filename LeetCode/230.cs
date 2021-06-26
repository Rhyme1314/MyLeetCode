using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _230//二叉搜索树中第K小的元素
    {
        int res = 0;
        public int KthSmallest(TreeNode root, int k)
        {
            InOrder(root, 0, k);
            return res;
        }
        private void InOrder(TreeNode node, int n,int k)
        {
            if (node == null)
                return;
            InOrder(node.left,n,k);
            n++;
            if (n==k)
            {
                res = node.val;
                return;
            }
            InOrder(node.right,n,k);
        }
    }
}
