using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _714// 买卖股票的最佳时机含手续费
    {
        public int MaxProfit(int[] prices, int fee)
        {
            int len = prices.Length;
            int[] dp1 = new int[len];//dp1[i]//代表第i天不持股所拥有的的最大金钱
            int[] dp2 = new int[len];//dp2[i]代表 第 i 天 持股 所拥有的的最大金钱\
            dp1[0] = 0;
            dp2[0] = -prices[0];
            for (int i = 1; i < len; i++)
            {
                dp2[i] = Math.Max(dp2[i - 1], dp1[i - 1] - prices[i]);
                dp1[i] = Math.Max(dp1[i - 1], dp2[i] + prices[i]-fee);
            }
            return dp1[len - 1];
        }
    }
}
