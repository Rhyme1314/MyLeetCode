using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _167//两数之和 II - 输入有序数组
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;int right = numbers.Length - 1;
            while (right>left)
            {
                if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else return new int[2] { left+1, right+1 };
            }
            return new int[2] { left+1, right+1 };
        }
    }
}
