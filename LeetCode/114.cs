using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _114//二叉树展开为链表
    {
        List<TreeNode> preOrderList = new List<TreeNode>();
        public void Flatten(TreeNode root)
        {
            PreOrder(root);
            for (int i = preOrderList.Count-2; i >=0; i--)
            {
                preOrderList[i].right = preOrderList[i + 1];
                preOrderList[i].left = null;
            }
            
        }
        private void PreOrder(TreeNode node)
        {
            if (node==null)
            {
                return;
            }
            preOrderList.Add(node);
            PreOrder(node.left);
            PreOrder(node.right);
        }
    }
}
