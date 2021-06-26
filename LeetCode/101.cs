using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _101//对称二叉树
    {
        public bool IsSymmetric(TreeNode root)
        {
            return BFS(root, root);
        }
        private bool DFS(TreeNode nodeL,TreeNode nodeR)
        {
            if (nodeL==null&&nodeR==null)
            {
                return true;
            }
            if (nodeL==null||nodeR==null)
            {
                return false;
            }
            if (nodeL.val == nodeR.val)
            {
                return DFS(nodeL.left, nodeR.right) && DFS(nodeL.right, nodeR.left);
            }
            else
                return false;
        }
        private bool BFS(TreeNode nodeL, TreeNode nodeR)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(nodeL);queue.Enqueue(nodeR);
            while (queue.Count!=0)
            {
                nodeL = queue.Dequeue();
                nodeR = queue.Dequeue();
                if (nodeL==null&&nodeR==null)
                    continue;
                if (nodeL == null || nodeR == null||nodeL.val!=nodeR.val)
                    return false;


                queue.Enqueue(nodeL.left);
                queue.Enqueue(nodeR.right);
                queue.Enqueue(nodeL.right);
                queue.Enqueue(nodeR.left);
            }
            return true;
        }
    }
}
