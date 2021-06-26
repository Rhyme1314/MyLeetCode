using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
       }
  }
    //给你二叉树的根节点 root ，返回它节点值的   前序 遍历。
    class _144
    {
        
        List<int> res = new List<int> ();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            PreOrder(root);
            return res;
        }
        private void PreOrder(TreeNode node)//不需要更新 故返回值为void
        {
            if (node == null)
                return; //递归结束

            res.Add(node.val);
            PreOrder(node.left);
            PreOrder(node.right);
            

        }
    }
}
