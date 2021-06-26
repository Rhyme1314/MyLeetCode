using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _240//搜索二维矩阵 II
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            #region 暴力法
            //int column = matrix.Length;
            //int row = matrix[0].Length;
            //for (int j = 0; j < row; j++)
            //{
            //    if (matrix[0][j] == target)
            //        return true;
            //    else if (matrix[0][j] > target)
            //        row = j;
            //}
            //for (int i = 0; i < column; i++)
            //{
            //    if (matrix[i][0] == target)
            //        return true;
            //    else if (matrix[i][0] > target)
            //        column = i;
            //}
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (matrix[i][j] == target)
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
            #endregion
            #region 二分查找 可以用 但是也挺复杂  没写

            #endregion
            int column = matrix.Length;
            int row = matrix[0].Length;
            int x = 0;
            int y = column - 1;
            while (x>=0&&x<row&&y>=0&&y<column)
            {
                if (matrix[y][x] < target)
                    x++;
                else if (matrix[y][x] > target)
                    y--;
                else return true;
            }
            return false;
        }
    }
}
