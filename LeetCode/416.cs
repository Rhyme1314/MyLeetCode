using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _416//分割等和子集
    {
        public bool CanPartition(int[] nums)
        {
            #region DP解01背包问题
            //int sum = 0;
            //foreach (int num in nums) sum += num;
            //if ((sum & 1) == 1) return false;//总和为奇数  那肯定分不成两半 
            //int n = nums.Length;
            //int halfSum = sum / 2;
            //bool[,] dp = new bool[n + 1, halfSum + 1];//DP[i,j]代表 nums中1~i中的物品 能否凑齐j这个数目
            //for (int i = 0; i < n + 1; i++)
            //{
            //    for (int j = 0; j < halfSum + 1; j++)
            //    {
            //        if (i == 0 && j == 0)
            //            dp[i, j] = true;
            //        else if (i == 0)
            //            dp[i, j] = false;//没有物品 肯定不能凑齐
            //        else if (j == 0)
            //            dp[i, j] = true;//全都不选 就能凑齐
            //        else
            //        {
            //            if (j - nums[i - 1] >= 0)//首先你不能超出界限 
            //                dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i - 1]];//前i-1个能凑齐 那么i个也能凑齐 
            //                                                                      //前i-1个能凑齐j-nums[i-1]  (这里的nums[i-1]对应的是第i个物品的重量) 那么加上第i个物品也能凑齐j
            //            else
            //                dp[i, j] = dp[i - 1, j];//如果你nums[i-1]太大了 就不能选第i个物品了 
            //        }
            //    }
            //}
            //return dp[n, halfSum];
            #endregion

            int sum = 0;
            foreach (int num in nums) sum += num;
            if ((sum & 1) == 1) return false;//总和为奇数  那肯定分不成两半 
            int n = nums.Length;
            int halfSum = sum / 2;
            bool[] dp = new bool[halfSum + 1];
            dp[0] = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = halfSum; j >=nums[i]; j--)
                {
                    dp[j] = dp[j] || dp[j - nums[i]];
                }
            }
            return dp[halfSum];


        }
    }
}
