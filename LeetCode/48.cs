using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _48//旋转图像
    {
        public void Rotate(int[][] matrix)
        {
            #region 暴力法
            //  int n = matrix.Length;
            //int[,] res = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //       res[i,j] = matrix[i][n-1-j];
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        matrix[i][j] = res[i,j];
            //    }
            //}
            #endregion
            #region 用一个temp
            int n = matrix.Length;
            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Swap(matrix, i, j);//水平反转
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Swap2(matrix, i, j);//对角线
                }
            }
            #endregion

        }
        public void Swap(int[][] matrix, int i, int j)
        {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[matrix.Length-1-i][j];
            matrix[matrix.Length - 1 - i][j] = temp;
        }
        public void Swap2(int[][] matrix, int i, int j)
        {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }
}
