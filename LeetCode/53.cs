using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   // 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
    class _53
    {
        public int MaxSubArray(int[] nums)
        {
            #region 暴力解法
            //int max = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        sum += nums[j];
            //        if (sum>max)
            //            max = sum;
            //    }
            //}
            //return max;
            #endregion
            #region 分治
            //有点复杂 等会写
            #endregion
            #region 贪心
            //nums[i]为当前元素
            //curSum 为当前数列和
            //preSum 为之前数列和
            //max为最大和
            //int curSum = nums[0];int preSum =nums[0]; int max = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (preSum < 0)
            //        preSum = 0;
            //    curSum = preSum + nums[i];
            //    if (max<curSum)
            //        max = curSum;
            //    preSum = curSum;
            //}
            //return max;

            #endregion
            #region 动态规划
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1]<0)
                    nums[i] = nums[i];
                else
                    nums[i]+=nums[i - 1];
            }
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                max = nums[i] > max ? nums[i] : max;
            }
            return max;
            #endregion
        }
    }
}
