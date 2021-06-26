using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _145
        //二叉树 后序遍历
    {
        List<int> res = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            PostOrder(root);
            return res;
        }
        private void PostOrder(TreeNode node)//不需要更新 故返回值为void
        {
            if (node == null)
                return; //递归结束


            PostOrder(node.left);

            PostOrder(node.right);
            res.Add(node.val);


        }
    }
}
