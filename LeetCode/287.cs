using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _287//寻找重复数
    {
        public int FindDuplicate(int[] nums)
        {
            #region 看不懂的二分查找
            //int left = 0; int right = nums.Length - 1; int res = -1;
            //while (right >= left)
            //{
            //    int mid = left + (right - left) / 2;
            //    int cnt = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (nums[i] <= mid)
            //            cnt++;
            //    }
            //    if (cnt <= mid)
            //    {
            //        left = mid + 1;
            //    }
            //    else
            //    {
            //        right = mid - 1;
            //        res = mid;
            //    }
            //}
            //return res;
            #endregion
            #region 快慢指针
            int slow = 0;
            int fast = 0;
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);
            return nums[slow];
            #endregion

        }

    }
}
