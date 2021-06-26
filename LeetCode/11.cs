using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _11//盛最多水的容器
    {
        public int MaxArea(int[] height)
        {
            int res = 0;
            int left = 0;int right = height.Length - 1;
            while (right>left)
            {
                if (height[right]>height[left])
                {
                    res = Math.Max(res, (right - left) * height[left]);
                    left++;
                }
                else
                {
                    res = Math.Max(res, (right - left) * height[right]);
                    right--;
                }
            }
            return res;
        }
    }
}
