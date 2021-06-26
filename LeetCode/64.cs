using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _64//最小路径和
    {
        public int MinPathSum(int[][] grid)
        {
            int column = grid.Length;
            int row = grid[0].Length;
            int[,] dp = new int[column, row];
            dp[0, 0] = grid[0][0];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (i - 1 >= 0 && j - 1 >= 0)
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                    else if (i - 1 >= 0)
                        dp[i, j] = dp[i - 1, j] + grid[i][j];
                    else if (j - 1 >= 0)
                        dp[i, j] = dp[i, j-1] + grid[i][j];
                }
            }
            return dp[column - 1, row - 1];
        }
    }
}
