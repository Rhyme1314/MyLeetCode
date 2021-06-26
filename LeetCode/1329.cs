using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1329//将矩阵按对角线排序
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            int column = mat.Length;
            int row = mat[0].Length;
            for (int i = 0; i < row; i++)
            {
                int length = 1;
                List<int> list = new List<int>();
                list.Add(mat[0][i]);
                while (length<column&&i+length<row)
                {
                    list.Add(mat[length][i + length]);
                    length++;
                }
                list.Sort();
                mat[0][i] = list[0];
                length = 1;
                while (length < column && i + length < row)
                {
                    mat[length][i + length] = list[length];
                    length++;
                }
            }
            for (int i = 0; i < column; i++)
            {
                int length = 1;
                List<int> list = new List<int>();
                list.Add(mat[i][0]);
                while (i+length < column && length < row)
                {
                    list.Add(mat[i+length][length]);
                    length++;
                }
                list.Sort();
                mat[i][0] = list[0];
                length = 1;
                while (i+length < column && length < row)
                {
                    mat[i+length][ length] = list[length];
                    length++;
                }
            }
            return mat;
        }
    }
}
