using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CBTInserter//完全二叉树插入器
    {
        List<TreeNode> nodeArray = new List<TreeNode>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int count = 0;
        public CBTInserter(TreeNode root)//BFS初始化nodeArray
        {
            nodeArray.Add(null);//第0个为空
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                nodeArray.Add(node); count++;
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }
        public int Insert(int v)
        {
            TreeNode node = new TreeNode(v);
            nodeArray.Add(node); count++;
            if (nodeArray[count / 2].left != null)
            {
                nodeArray[count / 2].right = node;
            }
            else nodeArray[count / 2].left = node;
            return nodeArray[count / 2].val;
        }
        public TreeNode Get_root()
        {
            return nodeArray[1];
        }
    }
}
