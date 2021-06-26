using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _100//相同的树
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return DFS(p, q);
        }
        private bool DFS(TreeNode p, TreeNode q)
        {
            if (p==null&&q==null)
                return true;
            else if (p==null||q==null)
                return false;
            if (p.val!=q.val)
                return false;
            return DFS(p.left, q.left) && DFS(p.right, q.right);
        }
    }
}
