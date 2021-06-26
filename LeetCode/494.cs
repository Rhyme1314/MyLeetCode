using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _494//目标和
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            #region DP 解决01背包问题
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //    sum += nums[i];
            //if (sum < Math.Abs(target) || (sum + target) % 2 != 0)
            //    return 0;
            //target = (sum + target) / 2;
            //int[,] dp = new int[nums.Length, target + 1];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    dp[i, 0] = 1;
            //    for (int j = 0; j < target + 1; j++)
            //    {
            //        //装和不装 两种方案
            //        if (i - 1 >= 0 && j - nums[i] >= 0)
            //        {
            //            dp[i, j] = dp[i - 1, j] + dp[i - 1, j - nums[i]];
            //        }
            //        else if (i - 1 >= 0 && nums[i] - j > 0)
            //        {
            //            dp[i, j] = dp[i - 1, j];
            //        }
            //        else if (i == 0 && nums[0] == j)
            //        {
            //            dp[i, j]++;
            //        }
            //    }
            //}
            //return dp[nums.Length - 1, target];
            #endregion
            #region DP  空间优化版本 不会做
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            if (sum < Math.Abs(target) || (sum + target) % 2 != 0)
                return 0;
            target = (sum + target) / 2;
            int[] dp = new int[target + 1];
            dp[0] = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = target; j >= nums[i]; j--)
                {
                    dp[j] = dp[j] + dp[j - nums[i]];
                }
            }
            return dp[target];
            #endregion



        }
    }
}
