using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _162//寻找峰值
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length==1)
                return 0;
            if (nums[0]>nums[1])
                return 0;
            if (nums[nums.Length - 1] > nums[nums.Length - 2])
                return nums.Length - 1;
            //边界条件
            int left = 0;int right = nums.Length - 1;
            while (left<=right)
            {
                int mid = left + (right - left) / 2;//防止整型溢出
                if (mid==0)
                    mid++;
                if (nums[mid] > nums[mid + 1] && nums[mid] > nums[mid - 1])
                    return mid;
                else if (nums[mid]<nums[mid-1])
                    right = mid - 1;
                else if (nums[mid]<nums[mid+1])
                    left = mid + 1;
            }
            throw new ArgumentException("执行不到这一步");
        }
    }
}
