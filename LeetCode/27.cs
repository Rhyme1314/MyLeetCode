﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _27
    {
        //给你一个数组 nums和一个值 val，你需要 原地 移除所有数值等于 val的元素，并返回移除后数组的新长度。
        //不要使用额外的数组空间，你必须仅使用 O(1) 额外空间并 原地 修改输入数组。
        //元素的顺序可以改变。你不需要考虑数组中超出新长度后面的元素。
        //输入：nums = [3,2,2,3], val = 3
        //输出：2, nums = [2,2]
        //解释：函数应该返回新的长度 2, 并且 nums 中的前两个元素均为 2。你不需要考虑数组中超出新长度后面的元素。
        //例如，函数返回的新长度为 2 ，而 nums = [2, 2, 3, 3] 或 nums = [2, 2, 0, 0]，也会被视作正确答案。
        public static int Test(int[] nums, int val)
        {
            #region 不改变顺序的解法
            //int n = nums.Length;
            //int j = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (nums[i] != val)
            //    {
            //        nums[j] = nums[i]; j++;
            //    }
            //}
            //return j;
            #endregion
            #region 双指针解法
            int n = nums.Length;
            int j = n - 1;//右指针
            for (int i = 0; i <= j; i++)
            {
                if (nums[j]==val)
                {
                    j--;i--;
                }
                 else if (nums[i]==val)
                {
                    int temp = nums[i];nums[i] = nums[j];nums[j] = temp;
                    i--;
                }
            }
            return j+1;
            #endregion
        }

    }
}