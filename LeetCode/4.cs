using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _4//寻找两个正序数组的中位数
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            int[] nums3 = new int[n + m];
            for (int i = 0; i < n; i++)
            {
                nums3[i] = nums1[i];
            }
            for (int j = 0; j < m; j++)
            {
                nums3[n + j] = nums2[j];
            }
            Array.Sort(nums3);
            if (((n+m)&1)==1)//为奇数
            {
                return nums3[(m + n) / 2];
            }
            return (nums3[(m + n) / 2] + nums3[((m + n) / 2) - 1]) / (double)2;
        }
    }
}
