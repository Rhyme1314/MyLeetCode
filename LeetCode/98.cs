using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _98//验证二叉搜索树
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MaxValue, long.MinValue);
        }
        public bool IsValidBST(TreeNode node, long bigger, long smaller)
        {
            if (node == null)
            {
                return true;
            }
            if (node.val>= bigger || node.val<= smaller)
            {
                return false;
            }
            return IsValidBST(node.left, node.val,smaller ) && IsValidBST(node.right, bigger, node.val);
        }



    }
}
