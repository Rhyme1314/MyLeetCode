using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _938
    {
        //bool start = false;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            #region 中序遍历
            //int res = 0;
            //InOrder(root, ref res, low, high);
            //return res;
            return DFS(root,low, high);
            #endregion


        }
        private void InOrder(TreeNode node,ref int res,int low,int high)
        { 
            if (node == null)
                return; //递归结束
            InOrder(node.left,ref res,low,high);
            if (node.val <= high && node.val >= low)
                res += node.val;
            InOrder(node.right, ref res,low,high);
        }
        private int DFS(TreeNode node, int low, int high)
        {
            if (node == null)
                return 0 ;
            if (node.val>high)
            {
                return DFS(node.left, low, high);
            }
            if (node.val<low)
            {
                return DFS(node.right, low, high);
            }
            return node.val + DFS(node.left, low, high) + DFS(node.right, low, high);
        }
    }
}
