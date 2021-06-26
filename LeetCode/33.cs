using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _33// 搜索旋转排序数组
    {//肯定是要二分查找的 
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
                return nums[0] == target ? 0 : -1;
            int left = 0;int right = nums.Length - 1;
            if (target<nums[left]&&target>nums[right])
                return -1;
            while (right>left)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid]==target)
                    return mid;
                if (nums[mid] >= nums[0])//说明左半部分是有序的
                {
                    if (nums[mid] > target && nums[left] < target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else {//此时右半部分有序
                    if (nums[mid] < target && nums[right] > target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
