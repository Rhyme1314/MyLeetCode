using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _654// 最大二叉树
    {
       // Dictionary<int, int> dic = new Dictionary<int, int>();
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
           return DiGui(nums, 0, nums.Length - 1);
        }
        private TreeNode DiGui(int[] nums,int left,int right)
        {
            if (left>=right)
                return null;
            int maxIndex = 0;int max = nums[left];
            for (int i = left; i <=right; i++)
            {
                max = max > nums[i] ? max : nums[i];
                maxIndex = max > nums[i] ? maxIndex : i;
            }//找出最大节点
            TreeNode node = new TreeNode(max);
            node.left = DiGui(nums, left, maxIndex - 1);
            node.right = DiGui(nums, maxIndex+1, right);
            return node;
        }
    }
}
