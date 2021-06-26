using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //    给定一个含有 n个正整数的数组和一个正整数 target 。

    //找出该数组中满足其和 ≥ target 的长度最小的 连续子数组[numsl, numsl + 1, ..., numsr - 1, numsr] ，并返回其长度。如果不存在符合条件的子数组，返回 0

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/minimum-size-subarray-sum
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _209//长度最小的子数组
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            #region 队列实现滑动数组
            //Queue<int> queue = new Queue<int>();
            //int res =nums.Length;
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    queue.Enqueue(nums[i]);
            //    sum += nums[i];
            //    while (sum - queue.Peek() >= target)
            //    {
            //        sum-= queue.Dequeue();
            //    }
            //    if (res > queue.Count && sum>=target)
            //        res = queue.Count;
            //}
            //return sum >= target ? res : 0;
            #endregion
            //应该有更好的办法
            #region 使用双指针实现滑动数组
            if (nums.Length==0)
                return 0;
            int left = 0;int right = 0;
            int sum = 0; int res = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[right];
                right++;
                while (sum-nums[left]>=target)
                {
                    sum -= nums[left];
                    left++;
                }
                if (sum >= target && res > right - left)
                    res = right - left;
            }
            return sum >= target ? res : 0;
            #endregion

        }
    }
}
