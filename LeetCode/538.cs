using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _538//把二叉搜索树转换为累加树
    {
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
           DFS(root);
            return root;
        }

        private  void DFS(TreeNode node)
        {
            if (node == null)
                return;
            DFS(node.right);
            sum += node.val;
            node.val = sum;
             DFS(node.left);
        }
    }
}
