using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _113//路径总和
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, new List<int>(), targetSum);
            return res;
        }
        private void DFS(TreeNode node, List<int> curlist,int target)
        {
            if (node==null)
                return;
            curlist.Add(node.val);
            if (node.left==null&&node.right==null&&target==node.val)//叶子结点成立
            {
                res.Add(new List<int>(curlist));
            }
            DFS(node.left, curlist, target - node.val);
            DFS(node.right, curlist, target - node.val);
            curlist.RemoveAt(curlist.Count-1);
        }
    }
}
