using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1110//删点成林
    {
        IList<TreeNode> res = new List<TreeNode>();
        // Dictionary<int, TreeNode> dic = new Dictionary<int, TreeNode>();
        HashSet<int> set;
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            set = new HashSet<int>(to_delete);//先变集合
            DFS(root);
            res.Add(root);
            return res;
        }
        private TreeNode DFS(TreeNode node)//前序遍历完了之后
        {
            if (node == null)
                return null;

            node.left = DFS(node.left);
            node.right= DFS(node.right);
            if (set.Contains(node.val))
            {
                if (node.left != null)
                {
                    res.Add(node.left);
                }
                if (node.right != null)
                {
                    res.Add(node.right);
                }
                node = null;//删除结点
            }
            return node;
        }
    }
}
