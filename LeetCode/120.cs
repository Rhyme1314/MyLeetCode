using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _120//三角形最小路径和
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count==1)
                return triangle[0][0];
            int column = triangle.Count;
            int row = triangle[column - 1].Count;
            int[,] dp = new int[column, row];
            dp[0, 0] = triangle[0][0];
            for (int i = 1; i < column; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0)
                    {
                        dp[i, j] =  dp[i - 1, j] + triangle[i][j];
                    }
                    else if (j==i)
                    {
                        dp[i, j] = dp[i - 1, j - 1] + triangle[i][j];
                    }
                    else
                        dp[i, j] = Math.Min(dp[i - 1, j], dp[i - 1, j - 1]) + triangle[i][j];
                }
            }
            int res = dp[column-1,0] ;
            for (int i = 0; i < row; i++)
            {
                res = Math.Min(res, dp[column - 1, i]);
            }
            return res;
        }
    }
}
