using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _105//从前序 中序 遍历序列构造二叉树
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();//中序遍历的值的索引
        public TreeNode BulidTree(int[] preorder, int[] inorder)
        {
            int n = inorder.Length;
            for (int i = 0; i < n; i++)
                dic[inorder[i]] = i;
            return myBuildTree(preorder, inorder, 0, n - 1, 0, n - 1);
        }
        public TreeNode myBuildTree(int[] preorder, int[] inorder,int preorder_left,int preorder_right,int inorder_left,int inorder_right)
        {
            if (preorder_left>preorder_right)//子数组被遍历完了
                return null;

            int preorder_root = preorder_left;//root是索引 不是值 preorder_left初始为0
            int inorder_root = dic[ preorder[preorder_root]];//定位根结点在
            TreeNode root = new TreeNode(preorder[preorder_root]);
            int root_leftSize = inorder_root - inorder_left;
            root.left = myBuildTree(preorder, inorder, preorder_left+1, preorder_left+root_leftSize, inorder_left, inorder_root-1);
            root.right = myBuildTree(preorder, inorder, preorder_left + root_leftSize + 1, preorder_right,inorder_root + 1, inorder_right);
            return root;
        }
    }
}
