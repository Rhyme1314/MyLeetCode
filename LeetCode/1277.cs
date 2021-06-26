using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1277// 统计全为 1 的正方形子矩阵
    {
        public int CountSquares(int[][] matrix)
        {
            int column = matrix.Length;
            int row = matrix[0].Length;
            int[,] dp = new int[column, row];
            int res = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i - 1 >= 0 && j - 1 >= 0&&matrix[i][j]==1)
                    {
                        int temp = Math.Min(dp[i - 1, j], dp[i, j - 1]);
                        dp[i, j] = Math.Min(temp, dp[i - 1, j - 1]) + 1;
                    }
                    else dp[i, j] = matrix[i][j];
                    res += dp[i,j];
                }
            }
            return res;
        }
    }
}
