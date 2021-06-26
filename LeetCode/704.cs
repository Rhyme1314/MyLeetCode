using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _704//二分查找法
    {
        public int Search(int[] nums, int target)
        {

           return BinarySearch(nums, 0, nums.Length - 1, target);
        }
        private int BinarySearch(int[] nums,int left,int right,int target)
        {
            int mid = left + (right - left) / 2;//防止整型溢出
            if (left>right)
                return -1;
            if (nums[mid] == target)
                return mid;
            else if (left ==right)
                return -1;
            else if (nums[mid] < target)
                return BinarySearch(nums, mid + 1, right, target);
            else if (nums[mid] > target)
                return BinarySearch(nums, left, mid - 1, target);
            else
                return -1;
        }
    }
}
