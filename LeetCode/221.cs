using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //在一个由 '0' 和 '1' 组成的二维矩阵内，找到只包含 '1' 的最大正方形，并返回其面积。
    class _221
    {
        public int MaximalSquare(char[][] matrix)//最大正方形
        {
            int column = matrix.Length;
            int row = matrix[0].Length;
            int[,] dp = new int[column, row];
            int maxEdge = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {//dp[i,j]代表以i,j为右下角顶点的正方形的边长
                    if (matrix[i][j]=='0')
                        dp[i, j] = 0;
                    else
                    {
                        if (i-1>=0&&j-1>=0)
                        {
                            int temp = Math.Min(dp[i - 1, j], dp[i, j - 1]);
                            dp[i, j] = Math.Min(temp, dp[i - 1, j - 1]) + 1;
                        }
                         else dp[i, j] = 1;
                    }
                    maxEdge = Math.Max(dp[i, j], maxEdge);//最大边长
                }
            }
            return maxEdge * maxEdge;
        }
    }
}
