using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _257//二叉树的所有路径
    {
        IList<string> res = new List<string>();
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            DFS(root, "");
            return res;
        }
        private void DFS(TreeNode node,string str)
        {
            if (node==null)
            {
                return;
            }
            str += node.val;
            if (node.left==null&&node.right==null)
            {
                res.Add(str);
                return;
            }
            DFS(node.left, str + "->");
            DFS(node.right, str + "->");
        }
    }
}
