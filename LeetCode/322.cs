using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //给定不同面额的硬币 coins 和一个总金额 amount。编写一个函数来计算可以凑成总金额所需的最少的硬币个数。如果没有任何一种硬币组合能组成总金额，返回 -1。

    //你可以认为每种硬币的数量是无限的。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/coin-change
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _322
    {
        public int CoinChange(int[] coins, int amount)
        {
            #region 第一次做DP题目 抄的别人的代码
            //int[] Fn = new int[amount + 1];
            //Fn[0] = 0;
            //for (int i = 1; i <= amount; i++)
            //{
            //    Fn[i] = int.MaxValue;
            //    for (int j = 0; j < coins.Length; j++)
            //    {
            //        if (i - coins[j] >= 0 && Fn[i - coins[j]] != int.MaxValue)
            //        {
            //            Fn[i] = Math.Min(Fn[i - coins[j]] + 1, Fn[i]);
            //        }
            //    }
            //}
            //int res = Fn[amount];
            //return res == int.MaxValue ? -1 : res;
            #endregion
            #region 转成 完全背包问题解法 
            //long[,] dp = new long[coins.Length + 1, amount + 1];//dp[i,j]代表 前1~i种面额凑成j 所需要的最少的钞票
            //for (int i = 0; i < coins.Length + 1; i++)
            //{
            //    for (int j = 0; j < amount + 1; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        {
            //            dp[i, j] = 0;
            //        }
            //        else if (i == 0)
            //        {
            //            dp[i, j] = int.MaxValue;//不可能
            //        }
            //        else if (j == 0)
            //        {
            //            dp[i, j] = 0;
            //        }
            //        else
            //        {
            //            dp[i, j] = dp[i - 1, j];
            //            if (j >= coins[i - 1])
            //            {
            //                dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - coins[i - 1]] + 1);
            //            }
            //        }
            //    }
            //}
            //return dp[coins.Length, amount] >= int.MaxValue ? -1 : (int)dp[coins.Length, amount];
            #endregion
            #region 完全背包问题解法 优化
            int n = coins.Length;
            long[] dp = new long[amount + 1];
            for (int i = 0; i < amount+1; i++)
                dp[i] = int.MaxValue;
            dp[0] = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < amount+1; j++)
                {
                    if(j>=coins[i])
                    {
                        dp[j] = Math.Min(dp[j], dp[j - coins[i]]+1);
                    }
                }
            }
            return dp[amount]>=int.MaxValue?-1:(int)dp[amount];
            #endregion

        }

    }
}
