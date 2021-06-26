using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _198//打家劫舍
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;

            if (n == 1)
                return nums[0];
            if (n == 2)
                return nums[0] > nums[1] ? nums[0] : nums[1];

            int[] dp = new int[n];//dp[i]偷到第i家时可获得的最高金额
            dp[0] = nums[0];
            dp[1] = nums[1];
            dp[2] = nums[2] + nums[0];
            for (int i = 3; i < n; i++)
                dp[i] = Math.Max(dp[i - 2], dp[i - 3]) + nums[i];
            return dp[n - 1] > dp[n - 2] ? dp[n - 1] : dp[n - 2];
        }
    }
}
