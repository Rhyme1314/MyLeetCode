using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _26//删除有序数组中的重复项
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length<2)
                return nums.Length;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[left]!=nums[i]) nums[++left] = nums[i];
            return left+1;
        }
    }
}
