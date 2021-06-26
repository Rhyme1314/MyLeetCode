using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _655//输出二叉树
    {
        IList<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            Queue<TreeNode> BFS = new Queue<TreeNode>();
            BFS.Enqueue(root);
            while (BFS.Count>0)
            {
                TreeNode curNode = BFS.Dequeue();
            }



            return res;
        }
    }
}
