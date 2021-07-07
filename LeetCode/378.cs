using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _378//有序矩阵中第 K 小的元素
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int[] nums = new int[n*n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nums[index++] = matrix[i][j];
                }
            }
            Array.Sort(nums);
            return nums[k-1];
        }
    }
}
