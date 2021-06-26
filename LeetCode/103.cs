using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _103//二叉树的锯齿形层序遍历
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null)
                return res;

           // IList<int> empty = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            #region BFS 错了
            bool reverse = true;
            queue.Enqueue(root);
            int levelCount = 1;
            int nextLevelCount = 0;
            IList<int> curlist = new List<int>();
            while (queue.Count != 0)
            {
                TreeNode curNode = queue.Dequeue();
                if (reverse)
                {
                    curlist.Add(curNode.val);
                }
                else
                    curlist.Insert(0, curNode.val);
                levelCount--;
                if (curNode.left != null)
                {
                    queue.Enqueue(curNode.left);
                    nextLevelCount++;
                }
                if (curNode.right != null)
                {
                    queue.Enqueue(curNode.right);
                    nextLevelCount++;
                }
                if (levelCount == 0)
                {
                    res.Add(new List<int>(curlist));
                    curlist.Clear();
                    levelCount = nextLevelCount;
                    nextLevelCount = 0;
                    reverse = !reverse;
                }
            }
            #endregion
            //需要使用传说中的双端队列
            //DFS(root, 0);
            return res;
        }
        private void DFS(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (level >= res.Count)
            {
                res.Add(new List<int>());
            }
            if (level%2==0)
            {
                res[level].Add(node.val);
            }
            else
            {
                res[level].Insert(0, node.val);
            }
            
            DFS(node.left, level + 1);
            DFS(node.right, level + 1);


        }
    }
}
