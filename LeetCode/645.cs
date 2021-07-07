using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _645// 错误的集合
    {
        public int[] FindErrorNums(int[] nums)
        {
            #region HashSet
            //HashSet<int> set = new HashSet<int>();
            //int n = nums.Length;int[] res = new int[2];
            //for (int i = 0; i < n; i++)
            //{
            //    if (!set.Add(nums[i]))
            //    {
            //        res[0] = nums[i];
            //    }
            //}
            //for (int i = 1; i <= n; i++)
            //{
            //    if (set.Add(i))
            //    {
            //        res[1] = i;
            //    }
            //}
            //return res;
            #endregion
            int n = nums.Length;int[] res = new int[2];
            for (int i = 0; i < n; i++)
            {
                int index = (nums[i]-1) % n;
                nums[index] += n;
            }
            for (int i = 0; i < n; i++)
            {
                if ((nums[i]-1)/n>=2)
                {
                    res[0] = i + 1;
                }
                if (nums[i]<=n)
                {
                    res[1] = i + 1;
                }
            }
            return res;

        }
    }
}
