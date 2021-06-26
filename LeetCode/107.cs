using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _107//二叉树层序遍历 II
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            #region 两次DFS  性能96%+80% 取巧做法
            //IList<IList<int>> res = new List<IList<int>>();
            //if (root == null)
            //    return res;
            //LevelOrderDFS(root, 0, res);
            //LevelOrderDFS2(root, 0, res);
            //return res;
            #endregion
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
                return res;
            IList<int> empty = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Stack<IList<int>> stack = new Stack<IList<int>>();
            queue.Enqueue(root);
            LevelOrder(queue, stack, empty);
            for (int i = 0; i < stack.Count; i++)
            {
                res.Add(stack.Pop());
            }
            return res;
            

        }

        private void LevelOrder(Queue<TreeNode> queue, Stack<IList<int>> stack, IList<int> curList)
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
                stack.Push(newlist);
                curList.Clear();
            }
        }

        private void LevelOrderDFS(TreeNode node, int index, IList<IList<int>> res)
        {
            if (node == null)
                return;
            if (index >= res.Count)
                res.Add(new List<int>());//res.Insert(index,new List<int>());
            LevelOrderDFS(node.left, index + 1, res);
            LevelOrderDFS(node.right, index + 1, res);
        }
        private void LevelOrderDFS2(TreeNode node, int index, IList<IList<int>> res)
        {
            if (node == null)
                return;
            res[res.Count - index-1].Add(node.val);
            LevelOrderDFS(node.left, index + 1, res);
            LevelOrderDFS(node.right, index + 1, res);
            
        }
    }
}
