using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _450//删除二叉搜索树中的节点
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                if (root.left == null && root.right == null) root = null;
                else if(root.right!=null)
                {
                    root.val = RightMin(root);
                    root.right = DeleteNode(root.right, root.val);
                }
                else
                {
                    root.val = leftMax(root);
                    root.left = DeleteNode(root.left, root.val);
                }
            }
            return root;
        }
        private int leftMax(TreeNode node)
        {
            node = node.left;
            while (node.right!=null)
            {
                node = node.right;
            }
            return node.val;
        }
        private int RightMin(TreeNode node)
        {
            node = node.right;
            while (node.left != null)
            {
                node = node.left;
            }
            return node.val;
        }
    }
}
