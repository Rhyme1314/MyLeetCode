using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _300//最长递增子序列
    {
        public int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            dp[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int beforeMax = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j]<nums[i])
                    {
                        beforeMax = Math.Max(beforeMax, dp[j]);
                    }
                }
                dp[i] = beforeMax + 1;
            }
            int res = dp[0];
            for (int i = 0; i < n; i++)
            {
                res = Math.Max(res, dp[i]);
            }
            return res; 
        }
    }
}
