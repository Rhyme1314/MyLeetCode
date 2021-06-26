using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1701//平均等待时间
    {
        public double AverageWaitingTime(int[][] customers)
        {
            int cusCount = customers.Length;
            long[] dp = new long[cusCount];
            long curTime = customers[0][0];
            dp[0] = curTime+customers[0][1] - customers[0][0];
            curTime += customers[0][1];
            for (int i = 1; i < cusCount; i++)
            {
                if (curTime<customers[i][0])
                    curTime = customers[i][0];
                dp[i] = dp[i - 1] + curTime - customers[i][0] + customers[i][1];
                curTime = curTime + customers[i][1];
            }
            double res =(dp[cusCount-1]*1.0) / (cusCount*1.0);
            return res;
        }
    }
}
