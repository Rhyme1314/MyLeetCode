using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //给你一个整数数组 nums ，请你找出数组中乘积最大的连续子数组（该子数组中至少包含一个数字）
    //，并返回该子数组所对应的乘积。
    class _152//乘积最大子数组
    {
        public int MaxProduct(int[] nums)
        {
            #region DQ 第一次自己写的
            //if (nums.Length == 1)
            //    return nums[0];
            //int n = nums.Length;
            //int[,] fn = new int[n, 2];
            ////初始化nums[0]
            //if (nums[0] > 0)
            //{
            //    fn[0, 0] = nums[0];//fn[i,0]为正数
            //    fn[0, 1] = 0;//fn[i,1]为负数
            //}
            //else if (nums[0] < 0)
            //{
            //    fn[0, 1] = nums[0];
            //    fn[0, 0] = 0;
            //}
            //else if (nums[0] == 0)
            //{
            //    fn[0, 0] = 0;
            //    fn[0, 1] = 0;
            //}
            //int max = fn[0, 0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        if (fn[i - 1, 0] != 0)
            //            fn[i, 0] = fn[i - 1, 0] * nums[i];//fn[i,0]为正数
            //        else
            //            fn[i, 0] = nums[i];

            //        if (fn[i - 1, 1] != 0)
            //            fn[i, 1] = fn[i - 1, 1] * nums[i];//fn[i,1]为负数
            //        else
            //            fn[i, 1] = 0;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        if (fn[i - 1, 0] != 0)
            //            fn[i, 1] = fn[i - 1, 0] * nums[i];
            //        else
            //            fn[i, 1] = nums[i];
            //        if (fn[i - 1, 1] != 0)
            //            fn[i, 0] = fn[i - 1, 1] * nums[i];
            //        else
            //            fn[i, 0] = 0;
            //    }
            //    else if (nums[i] == 0)
            //    {
            //        fn[i, 0] = 0;
            //        fn[i, 1] = 0;
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    max = Math.Max(fn[i, 0], max);
            //}
            //return max;
            #endregion
            #region DQ优化
            int n = nums.Length;
            int[] maxF = new int[n];//
            int[] minF = new int[n];
            maxF[0] = nums[0];
            minF[0] = nums[0];
            for (int i = 1; i < n; i++)
            {
                maxF[i] = Math.Max(nums[i], Math.Max(nums[i] * maxF[i - 1], nums[i] * minF[i - 1]));
                minF[i] = Math.Min(nums[i], Math.Min(nums[i] * maxF[i - 1], nums[i] * minF[i - 1]));
            }
            int res = maxF[0];
            for (int i = 0; i < n; i++)
            {
                res = Math.Max(res, maxF[i]);
            }
            return res;
            
            #endregion

        }
    }
}
