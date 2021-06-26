using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _236//二叉树的最近公共祖先
    {
        TreeNode res;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            HasPORQ(root, p, q);
            return res;

        }

        private bool HasPORQ(TreeNode node, TreeNode p, TreeNode q)
        {
            if (node==null)
            {
                return false;
            }
            bool Lson = HasPORQ(node.left, p, q);
            bool Rson = HasPORQ(node.right, p, q);
            if (Lson&&Rson  ||  ((node==p||node==q)&&(Lson||Rson)))
            {
                res = node;
            }

            return Lson || Rson || node == p || node == q;

        }
    }
}
