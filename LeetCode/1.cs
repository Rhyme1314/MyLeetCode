using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//两数之和！！！！
    class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            #region 字典存储每个值的索引
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(target - nums[i]))
            //    {
            //        return new int[] {dic[target - nums[i]] , i };
            //    }
            //    dic[nums[i]] = i;
            //}
            //return new int[0];
            #endregion
            #region 暴力解法
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j]==target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
            #endregion
        }
    }
}
