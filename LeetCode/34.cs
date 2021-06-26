using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _34//在排序数组中查找元素的第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {
            #region   O(N) 
            //int[] res = { -1, -1 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == target)
            //    {
            //        res[0] = i; break;
            //    }
            //}
            //for (int i = nums.Length - 1; i >= 0; i--)
            //{
            //    if (nums[i] == target)
            //    {
            //        res[1] = i; break;
            //    }
            //}
            //return res;
            #endregion
            //这种题肯定要用二分查找的啦 但是细节好多
            int[] res = { -1, -1 };
            int leftIndex = BinarySearch(nums, target, true);
            int rightIndex = BinarySearch(nums, target, false) - 1;
            if (leftIndex<=rightIndex&&rightIndex<nums.Length&&nums[leftIndex]==target&&nums[rightIndex]==target)
            {
                res =new int[] { leftIndex,rightIndex};
            }
            return res;
        }
            private int BinarySearch(int[] nums, int target, bool lower) {
                int left = 0;int right = nums.Length - 1;int index = nums.Length;
                while (left<=right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > target || (lower && nums[mid] >= target))
                    {
                        right = mid - 1;
                        index = mid;
                    }
                    else {
                        left = mid + 1;
                    }
                }

                return index;
            }
    }
}
