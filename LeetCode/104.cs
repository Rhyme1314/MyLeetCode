using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _104//二叉树的最大深度
    {
        int res = 1;
        public int MaxDepth(TreeNode root)
        {
            if (root==null)
                return 0;
            DFS(root,  1);
            return res;
        }
        private void DFS(TreeNode node,int count)
        {
            if (node == null)
                return;
            res = Math.Max(res, count);
            DFS(node.left, count++);
            DFS(node.right,  count++);
        }
    }
}
