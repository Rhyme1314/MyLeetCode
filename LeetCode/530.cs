using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _530//二叉搜索树的最小绝对差
    {
        List<int> InOrderList = new List<int>();
        public int GetMinimumDifference(TreeNode root)
        {
            InOrder(root);
            int res = InOrderList[1] - InOrderList[0];
            for (int i = 0; i < InOrderList.Count-1; i++)
            {
                res = Math.Min(res, InOrderList[i + 1] - InOrderList[i]);
            }
            return res;
        }
        private void InOrder(TreeNode node)
        {
            if (node==null)
            {
                return;
            }
            InOrder(node.left);
            InOrderList.Add(node.val);
            InOrder(node.right);
        }
    }
}
