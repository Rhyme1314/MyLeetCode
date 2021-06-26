using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _338//比特位计数
    {
        public int[] CountBits(int n)
        {
            int[] dp = new int[n + 1];
            int highBit = 0;
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((i&(i-1))==0)
                {
                    highBit = i;
                }
                dp[i] = dp[i - highBit] +1;
            }
            return dp;
        }
    }
}
