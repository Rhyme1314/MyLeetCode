using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _74//搜索二维矩阵
    {
        public  static bool SearchMatrix(int[][] matrix, int target)
        {
            #region 两次二分查找
            //int rowNum = matrix[0].Length;
            //int columeNum = matrix.Length;
            //int row = 0;//目标值所在行的索引
            //int top = 0;
            //int bottom = columeNum - 1;
            //while (bottom>=top)
            //{
            //    int mid = top + (bottom - top) / 2;
            //    if (matrix[mid][0] > target)//小于mid的最小值
            //        bottom = mid - 1;
            //    else if (matrix[mid][rowNum - 1] < target)//大于mid的最大值
            //        top = mid + 1;
            //    else
            //    {
            //        row = mid;break;
            //    }
            //}
            //int left = 0;
            //int right = rowNum - 1;
            //while (right>=left)
            //{
            //    int mid = left + (right - left) / 2;
            //    if (matrix[row][mid] < target)
            //        left = mid + 1;
            //    else if (matrix[row][mid] > target)
            //        right = mid - 1;
            //    else
            //        return true;
            //}
            //return false;
            #endregion //时间logN+logM
            #region 半暴力解法
            int rowNum = matrix[0].Length;//每一行的元素个数
            int columeNum = matrix.Length;//每列的元素个数
            for (int i = 0; i < columeNum; i++)
            {
                for (int j = rowNum-1; j >=0; j--)
                {
                    if (matrix[i][j]<target)
                        break;
                    if (matrix[i][j] == target)
                        return true;
                }
            }
            return false;
            #endregion
        }

    }
}
