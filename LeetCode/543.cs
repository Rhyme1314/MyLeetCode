using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _543//二叉树的直径
    {
        int ans = 1;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            GetDepth(root);
            return ans-1;
        }
        private int GetDepth(TreeNode node) {//用来获取node的两个子树的最大深度
            if (node==null)
            {
                return 0;
            }

            int LDepth = GetDepth(node.left);
            int RDepth = GetDepth(node.right);
            ans = Math.Max(LDepth + RDepth + 1, ans);
            return Math.Max(LDepth, RDepth) + 1;
        }
    }
}
