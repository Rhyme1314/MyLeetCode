using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _99//恢复二叉搜索树
    {
        public void RecoverTree(TreeNode root)
        {
            List<TreeNode> inOrderTree = new List<TreeNode>();
            int[] swap = new int[2];
            InOrder(root, inOrderTree);
            int left = 0;int right = inOrderTree.Count - 1;
            bool leftStop = false;
            bool rightStop = false;
            while (right>left)
            {
                if (!leftStop&&inOrderTree[left].val > inOrderTree[left + 1].val)
                {
                    swap[0] = left;leftStop = true;
                }
                if (!rightStop&&inOrderTree[right].val < inOrderTree[right - 1].val)
                {
                    swap[1] = right;rightStop = true;
                }
                if (!leftStop)
                {
                    left++;
                }
                if (!rightStop)
                {
                    right--;
                }
                if (leftStop&&rightStop)
                {
                    break;
                }
               
            }
            int temp = inOrderTree[swap[0]].val;
            inOrderTree[swap[0]].val = inOrderTree[swap[1]].val;
            inOrderTree[swap[1]].val = temp;
        }
        private void InOrder(TreeNode node, List<TreeNode> inOrderTree)
        {
            if (node==null)
                return;
            InOrder(node.left, inOrderTree);
            inOrderTree.Add(node);
            InOrder(node.right, inOrderTree);
        }
    }
}
