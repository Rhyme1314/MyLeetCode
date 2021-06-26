using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _102//二叉树 层序遍历
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            #region BFS实现层级遍历
            //IList<IList<int>> res = new List<IList<int>>();
            //if (root == null)
            //    return res;
            //IList<int> empty = new List<int>();
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //queue.Enqueue(root);
            //LevelOrder(queue, res, empty);
            //
            #endregion
            #region DFS实现层级遍历

            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            LevelOrderDFS(root, 0, res);
            return res;
            #endregion

        }
        private void LevelOrderDFS(TreeNode node,int index, IList<IList<int>> res)
        {
            if (node==null)
                return;
            if (index >= res.Count)
                res.Add(new List<int>());//res.Insert(index,new List<int>());
            res[index].Add(node.val);
            LevelOrderDFS(node.left, index + 1, res);
            LevelOrderDFS(node.right, index + 1, res);
        }
        private void LevelOrder( Queue<TreeNode> queue, IList<IList<int>> res, IList<int> curList)
        {
            while (queue.Count > 0)
            {
                int curLevelCount = queue.Count;
                for (int i = 0; i < curLevelCount; i++)
                {
                    TreeNode curNode = queue.Peek();
                    curList.Add(curNode.val);
                    if (curNode.left != null)
                    {
                        queue.Enqueue(curNode.left);//左孩子入队
                    }
                    if (curNode.right != null)
                    {
                        queue.Enqueue(curNode.right);//右孩子入队
                    }
                    queue.Dequeue();//出队
                }
                List<int> newlist = new List<int>(curList);
                res.Add(newlist);
                curList.Clear();
            }
        }
    }
}
