using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _112//路径总和
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return my(root, targetSum);
        }
        private bool my(TreeNode node, int targetSum)
        {
            if (targetSum==0)
                return true;
            if (node==null)
                return false;
            return my(node.left, targetSum - node.val) || my(node.right, targetSum - node.val);
        }
    }
}
