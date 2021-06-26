using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _63//不同路径2
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int column = obstacleGrid.Length;
            int row = obstacleGrid[0].Length;
            int[,] dp = new int[column, row];
            dp[0, 0] = 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[i, j] = 0;
                    }
                    else if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        dp[i, j] = dp[i - 1, j]+ dp[i, j - 1];
                    }
                    else if (i - 1 >= 0)
                    {
                        dp[i, j] = dp[i - 1, j]+ 0;
                    }
                    else if (j - 1 >= 0)
                    {
                        dp[i, j] = 0 + dp[i, j - 1];
                    }
                }
            }
            return dp[column - 1, row - 1];
        }
    }
}
