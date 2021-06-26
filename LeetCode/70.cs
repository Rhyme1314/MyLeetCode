using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//假设你正在爬楼梯。需要 n 阶你才能到达楼顶。

//每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？

//注意：给定 n 是一个正整数。
    class _70//爬楼梯
    {
        public int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i =2; i < n+1; i++)
            { 
                dp[i] = dp[i - 2] + dp[i - 1];
            }
            return dp[n];
        }
    }
}
