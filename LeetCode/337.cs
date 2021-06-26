using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _337//打家劫舍 III
    {
        Dictionary<TreeNode, int> select = new Dictionary<TreeNode, int>();//select[node] 为选择node所获得的最大金钱
        Dictionary<TreeNode, int> notselect = new Dictionary<TreeNode, int>(); //notselect[node] 为不选择node所获得的最大金钱
        public int Rob(TreeNode root)
        {
            DFS(root);
            return Math.Max(select[root], notselect[root]);
        }
        private void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            
            //notselect.DefaultIfEmpty<Dictionary<TreeNode, int>>(0);
            DFS(node.left);
            DFS(node.right);//先后序遍历 确保node.left 和node.right 都已经在dic中了
            int sl = 0;int sr = 0;int nl = 0;int nr = 0;
            if (node.left!=null)
            {
                nl = notselect[node.left];
                sl = select[node.left];
            }
            if (node.right != null)
            {
                nr = notselect[node.right];
                sr = select[node.right];
            }

            select[node] = node.val +nl+nr;//选择node 
            notselect[node] = Math.Max(sl,nl) + Math.Max(sr,nr);
            //不选择node 就会等于选择node.left和不选择node.left的最大值 + 
        }
    }
}
