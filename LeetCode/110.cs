using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _110//平衡二叉树
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root==null)
                return true;
            bool isBal = Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <= 1;
            return (isBal && IsBalanced(root.left) && IsBalanced(root.right));
        }

        private int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            int depth = Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
            return depth;

        }
    }
}
