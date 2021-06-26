using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _128//最长连续序列
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int n = nums.Length; int res = 0;
            for (int i = 0; i < n; i++)
            {
                set.Add(nums[i]);
            }
            for (int i = 0; i < n; i++)
            {
              
                int curRes = 1;
                int curNum = nums[i];
                if (set.Contains(curNum-1))
                {
                    continue;
                }
                while (set.Contains(curNum+1))
                {
                    curNum += 1;
                    curRes++;
                }
                res = Math.Max(curRes, res);
            }
            return res;
        }
    }
}
