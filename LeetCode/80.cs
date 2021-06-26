using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _80//删除有序数组中的重复项 II
    {
        public int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;
            if (n<2)
                return n;
            int left = 2;//int right = 2;
            for (int i = 2; i < n; i++)
            {
                if (nums[left-2]!=nums[i])
                {
                    nums[left] = nums[i];
                    left++;
                }
            }
            return left;
        }
    }
}
