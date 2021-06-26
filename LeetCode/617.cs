using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _617//合并二叉树
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return null;
            else if (root1 == null)
                return root2;
            else if (root2 == null)
                return root1;
            else
                return new TreeNode (root1.val+root2.val,MergeTrees(root1.left,root2.left),MergeTrees(root1.right,root2.right));
        }
        private TreeNode DFS(TreeNode node1, TreeNode node2)
        {
            if (node1==null&&node2==null)
            {
                return null;
            }
            else if (node1==null)
            {
                return node2;
            }
            else if (node2==null)
            {
                return node1;
            }
            else 
            {
                TreeNode node = new TreeNode(node1.val+node2.val);
                node.left = DFS(node1.left, node2.left);
                node.right = DFS(node1.right, node2.right);
                return node;
            }
        }
    }
}
