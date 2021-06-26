using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _73//矩阵置零
    {
        public void SetZeroes(int[][] matrix)
        {
            #region 并查集解法 失败 
            //int column = matrix.Length;
            //int row = matrix[0].Length;
            //UnionFind unionFind = new UnionFind(matrix);
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (matrix[i][j] == 0)
            //        {
            //            bool tiaojian = false;
            //            if (i > 0 && j > 0)
            //            {
            //                tiaojian = (unionFind.Find(i * row + j) != unionFind.Find(i * row + j - 1)
            //                && unionFind.Find(i * row + j) != unionFind.Find((i - 1) * row + j));//如果他的根不等于上行或者左边的根  说明这个0是一个独立的0
            //            }
            //            else if (i > 0)
            //            {
            //                tiaojian = (unionFind.Find(i * row + j) != unionFind.Find((i - 1) * row + j));
            //            }
            //            else if (j > 0)
            //            {
            //                tiaojian = (unionFind.Find(i * row + j) != unionFind.Find(i * row + j - 1));
            //            }
            //            else
            //                tiaojian = true;
            //            if (tiaojian)
            //            {
            //                for (int r = 0; r < row; r++)
            //                {
            //                    if (r == j) continue;
            //                    if (matrix[i][r] != 0)
            //                    {
            //                        matrix[i][r] = 0;
            //                        unionFind.Union(i * row + r, i * row + j);
            //                    }
            //                }
            //                for (int c = 0; c < column; c++)
            //                {
            //                    if (c == i) continue;
            //                    if (matrix[c][j] != 0)
            //                    {
            //                        matrix[c][j] = 0;
            //                        unionFind.Union(c * row + j, i * row + j);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion
            #region 空间M+N  抄的
            //int column = matrix.Length;
            //int row = matrix[0].Length;
            //bool[] ZeroRow = new bool[column];
            //bool[] ZeroCoulumn = new bool[row];
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (matrix[i][j] == 0)
            //        {
            //            ZeroRow[i] = ZeroCoulumn[j] = true;
            //        }
            //    }
            //}
            //for (int i = 0; i < column; i++)
            //{
            //    for (int j = 0; j < row; j++)
            //    {
            //        if (ZeroRow[i] || ZeroCoulumn[j])
            //        {
            //            matrix[i][j] = 0;
            //        }
            //    }
            //}
            #endregion
            #region 空间O(1)
            int column = matrix.Length;
            int row = matrix[0].Length;
            bool flag_column0 = false;
            bool flag_row0 = false;
            for (int i = 0; i < column; i++)
            {
                if (matrix[i][0]==0)//第一列
                {
                    flag_column0 = true;
                }
            }
            for (int i = 0; i < row; i++)
            {
                if (matrix[0][i] == 0)//第一行
                {
                    flag_row0 = true;
                }
            }
            for (int i = 1; i < column; i++)
            {
                for (int j = 1; j < row; j++)
                {
                    if (matrix[i][j]==0)
                    {
                        matrix[i][0] = matrix[0][j] = 0;
                    }
                }
            }
            for (int i = 1; i < column; i++)
            {
                for (int j = 1; j < row; j++)
                {
                    if (matrix[i][0] == 0||matrix[0][j]==0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            if (flag_column0)
            {
                for (int i = 0; i < column; i++)
                {
                    matrix[i][0] = 0;
                }
            }
            if (flag_row0)
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[0][i] = 0;
                }
            }


            #endregion


        }
    }
}
