using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _977// 有序数组的平方
    {
        public int[] SortedSquares(int[] nums)
        {
            int left = 0; int right = nums.Length - 1;
            int[] res = new int[nums.Length]; int index = right;
            while (right > left)
            {
                if (Math.Abs(nums[right]) >= Math.Abs(nums[left]))
                {
                    res[index--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    res[index--] = nums[left] * nums[left];
                    left++;
                }

            }
            return res;
        }
    }
}
