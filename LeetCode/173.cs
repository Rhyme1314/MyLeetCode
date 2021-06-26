using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BSTIterator//二叉搜索树迭代器
    {
        List<TreeNode> treeInOrder = new List<TreeNode>();
        int len = 0;
        int index = -1;
        public BSTIterator(TreeNode root)
        {
            InOrder(root);//先中序遍历整个树
        }
        private void InOrder(TreeNode node)
        {
            if (node==null)
                return;
            InOrder(node.left);
            treeInOrder.Add(node);
            len++;
            InOrder(node.right);
        }
        public int Next()
        {
            return treeInOrder[++index].val;
        }
        public bool HasNext()
        {
            return (index + 1) < len;
        }
    }
}
