using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _31//下一个排列
    {
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;int index = n - 1;
            for (int i = n-1; i >0; i--)
            {
                if (nums[i]>nums[i-1])
                {
                    index = i - 1;//找到最小的能改变的值
                    break;
                }
            }
            if (index == n - 1)//没找到  说明数组是降序排列
            { Array.Sort(nums); return; }
            int minIndex = index+1;
            for (int i = index+1; i < n; i++)
            {
                if (nums[i]>nums[index]&&nums[i]<nums[minIndex])
                {
                    minIndex = i;
                }
            }
            int temp = nums[index];nums[index] = nums[minIndex]; nums[minIndex] = temp;
            Array.Sort(nums, index + 1, n - index - 1);


        }
    }
}
