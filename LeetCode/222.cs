using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _222//完全二叉树的节点个数
    {

        public int CountNodes(TreeNode root)
        {
            Queue<TreeNode> BFS = new Queue<TreeNode>();
            int res = 0;
            BFS.Enqueue(root);
            while (BFS.Peek()==null)
            {
                TreeNode curNode = BFS.Dequeue();
                res++;
                BFS.Enqueue(curNode.left);
                BFS.Enqueue(curNode.right);
            }
            return res;
        }
        
    }
}
