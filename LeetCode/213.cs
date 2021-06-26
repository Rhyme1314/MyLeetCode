using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _213//打家劫舍II
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;

            if (n == 1)
                return nums[0];
            if (n == 2)
                return Math.Max(nums[0], nums[1]);
            #region 分两次DP
            //if (n == 3)
            //    return Math.Max(Math.Max(nums[0], nums[1]), nums[2]);

            //int[] dp1 = new int[n];//偷了第0家的 偷到第i家所获得的最高金额
            //int[] dp2 = new int[n];//没偷第0家的，偷到第i家所获得的最高金额
            //dp1[0] = nums[0];
            //dp1[1] = 0;
            //dp1[2] = nums[0] + nums[2];
            //for (int i = 3; i < n - 1; i++)
            //    dp1[i] = Math.Max(dp1[i - 2], dp1[i - 3]) + nums[i];
            //int max1 = Math.Max(dp1[n - 2], dp1[n - 3]);

            //dp2[0] = 0;
            //dp2[1] = nums[1];
            //dp2[2] = nums[2];
            //dp2[3] = nums[1] + nums[3];
            //for (int i = 4; i < n; i++)
            //    dp2[i] = Math.Max(dp2[i - 2], dp2[i - 3]) + nums[i];
            //int max2 = Math.Max(dp2[n - 1], dp2[n - 2]);

            //return Math.Max(max1, max2);

            #endregion
            #region 一次DP
            int[] dp = new int[n];
            dp[0] = nums[0];
            dp[1] = nums[1];
            for (int i = 2; i < n-1; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            int res1 = dp[n - 2];
            dp[0] = 0;
            dp[1] = nums[1];
            dp[2] = Math.Max(nums[1],nums[2]);
            for (int i = 3; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            }
            int res2 = dp[n - 1];
            return Math.Max(res1, res2);
            #endregion

        }
    }
}
