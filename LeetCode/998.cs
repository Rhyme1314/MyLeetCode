using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _998//最大二叉树 II
    {
        public TreeNode InsertIntoMaxTree(TreeNode root, int val)
        {
            return DFS(root, val);
        }
        private TreeNode DFS(TreeNode node, int val)
        {
            if (val > node.val)
            {
                TreeNode newNode = new TreeNode(val);
                newNode.left = node;
                return newNode;
            }
            if (node == null)
            {
                TreeNode newNode = new TreeNode(val);
                return newNode;
            }
            node.right = DFS(node.right, val);
            return node;
        }
    }
}
