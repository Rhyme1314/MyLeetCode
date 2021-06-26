using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _94
    {//中序遍历
        List<int> res = new List<int>();
        public IList<int> InOrderTraversal(TreeNode root)
        {
            InOrder(root);
            return res;
        }
        private void InOrder(TreeNode node)//不需要更新 故返回值为void
        {
            if (node == null)
                return; //递归结束
            InOrder(node.left);
            res.Add(node.val);
            InOrder(node.right);
           
        }
    }
}
