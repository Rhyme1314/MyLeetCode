using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _121//买卖股票的最佳时机
    {
        public int MaxProfit(int[] prices)
        {
            #region DP
            int n = prices.Length;
            int[,] dp = new int[n, 2];//确定状态
            dp[0, 0] = 0;
            dp[0, 1] = -prices[0];//初始条件
            for (int i = 1; i < n; i++)
            {
                dp[i, 0] = Math.Max(dp[i,0],dp[i - 1, 1] + prices[i]);
                dp[i, 1] = Math.Max(dp[i - 1,1], -prices[i]);//持股时的钱
                //当dp[i,1]变动的时候 就是在i天买入
            }
            return dp[n - 1, 0];
           // return res<0?0:res;

            #endregion
        }
    }
}
