using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _877//石子游戏 与486类似
    {
        public bool StoneGame(int[] piles)
        {
            int n = piles.Length;
            int[,] dp = new int[n, n];//dp[i,j]代表从piles[i]->piles[j]数组的最大净分差
                                      //因为我先手 所以最后肯定是我的一手选择减去下一阶段的最大净分差 
                                      //如果下一阶段的最大净分差 >我的一手选择的值 说明我怎么选都无力回天
            for (int i = 0; i < n; i++)
                dp[i, i] = piles[i];//如果只剩一个pile[i] 那么不管谁选 此时的净分差就是Pile[i]
            for (int i = n-2; i >=0; i--)
            {
                for (int j = i+1; j < n; j++)
                {
                    dp[i, j] = Math.Max(piles[i] - dp[i + 1, j], piles[j] - dp[i, j - 1]);
                }
            }
            return dp[0, n - 1] > 0;

        }
    }
}
