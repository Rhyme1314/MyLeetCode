using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1833//雪糕的最大数量
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            #region 排序+贪心
            //Array.Sort(costs); int res = 0;
            //for (int i = 0; i < costs.Length; i++)
            //{
            //    if (coins > costs[i])
            //    {
            //        res++;
            //        coins -= costs[i];
            //    }
            //    else break;
            //}
            //return res;
            #endregion
            #region DP  超内存
            //int n = costs.Length;
            //int[,] dp = new int[n + 1, coins + 1];
            //for (int i = 0; i < n + 1; i++)
            //{
            //    for (int j = 0; j < coins + 1; j++)
            //    {
            //        if (i == 0 && j == 0)
            //            dp[i, j] = 0;
            //        else if (i == 0) dp[i, j] = 0;
            //        else if (j == 0) dp[i, j] = 0;
            //        else
            //        {
            //            if (j >= costs[i - 1])
            //            {
            //                dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - costs[i - 1]] + 1);
            //            }
            //            else dp[i, j] = dp[i - 1, j];
            //        }
            //    }
            //}
            //return dp[n, coins];
            #endregion

            #region 计数排序
            int[] freq = new int[100001];int res = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                freq[costs[i]]++;
            }
            for (int i = 1; i < freq.Length; i++)
            {
                if (coins > i)
                {
                    int count = Math.Min(freq[i], coins / i);
                    res += count;
                    coins -= freq[i] * i;
                }
                else break;
            }
            return res;

            #endregion
        }
    }
}
