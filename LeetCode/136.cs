using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _136
    {
        public int SingleNumber(int[] nums)
        {
            #region 异或
            //int res = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    res = res ^ nums[i];
            //}
            //return res;
            #endregion
            #region 哈希集合

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Add(nums[i]))
                {
                    set.Remove(nums[i]);
                } 
            }
            return set.First();
            #endregion

        }
    }
}
