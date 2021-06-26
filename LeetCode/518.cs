using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _518//零钱兑换 II
    {
        public int Change(int amount, int[] coins)
        {
            #region 完全背包问题 DP
            //int n = coins.Length;
            //int[] dp = new int[amount + 1];
            //dp[0] = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 1; j < amount + 1; j++)
            //    {
            //        if (j >= coins[i])
            //        {
            //            dp[j] += dp[j - coins[i]];
            //        }
            //    }
            //}
            //return dp[amount];
            #endregion
            #region 完全背包问题 全局DP
            //int n = coins.Length;
            //int[,] dp = new int[n + 1, amount + 1];//dp[i,j]代表 从1~i这几种硬币种凑齐j 的方案数量
            //for (int i = 0; i < n + 1; i++)
            //{
            //    for (int j = 0; j < amount + 1; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        {
            //            dp[i, j] = 1;
            //        }
            //        else if (i == 0)
            //        {
            //            dp[i, j] = 0;
            //        }
            //        else if (j == 0)
            //        {
            //            dp[i, j] = 1;
            //        }
            //        else
            //        {
            //            dp[i, j] = dp[i - 1, j];
            //            if (j >= coins[i - 1])
            //            {
            //                dp[i, j] += dp[i, j - coins[i - 1]];
            //            }
            //        }
            //    }
            //}
            //return dp[n, amount];
            #endregion
            int n = coins.Length;
            int[] dp = new int[amount + 1];
            dp[0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = coins[i]; j < amount+1; j++)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }
            return dp[amount];

        }
    }
}
