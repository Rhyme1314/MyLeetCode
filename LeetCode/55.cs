using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //    给定一个非负整数数组 nums ，你最初位于数组的 第一个下标 。

    //数组中的每个元素代表你在该位置可以跳跃的最大长度。

    //判断你是否能够到达最后一个下标
    class _55
    {
        public bool canJump = false;
        public bool CanJump(int[] nums)
        {
            #region 贪心 每次选择跳的最远的
            //if (nums.Length == 1)
            //    return true;
            //Jump(nums, 0);
            //return canJump;
            #endregion
            #region 方法2 错误！！！
            //if (nums.Length == 1)
            //    return true;
            //if (nums[0] == 0)
            //    return false;
            //return Jump2(nums);
            #endregion
            #region DQ
            int n  = nums.Length;
            bool[] Fn = new bool[n];
            Fn[0] = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Fn[j]==true && nums[j]>=i-j)
                    {
                        Fn[i] = true;
                        break;
                    }
                }
            }
            return Fn[n - 1];
            #endregion

        }
        private bool Jump2(int[] nums)
        {
            //int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i==nums.Length-1)
                    return true;
                if (nums[i]==0)
                    nums[i] = nums[i - 1] - 1;
                if (nums[i]==0)
                    return false;
            }
            return true;
        }
        private void Jump(int[] nums, int curPos)
        {
            if (nums[curPos] == 0)
            {
                canJump = false;
                return;
            }      
            int target = curPos + 1;
            for (int i = curPos+1; i <= curPos+nums[curPos]; i++)
            {//跳跃范围
                if (i == nums.Length-1)
                {
                    canJump = true;
                    return;
                }
                if (i-curPos+nums[i]>=target-curPos+nums[target])
                {
                    target = i;
                }
            }
            Jump(nums, target);
        }
        private bool Jump3(int[] nums)
        {
            int rightmost = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i<=rightmost)
                {
                    rightmost = Math.Max(rightmost, i + nums[i]);
                }
                if (rightmost>=nums.Length-1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
