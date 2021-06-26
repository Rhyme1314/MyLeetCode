using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    给定一个整数数组，判断是否存在重复元素。

//如果存在一值在数组中出现至少两次，函数返回 true 。如果数组中每个元素都不相同，则返回 false 。
    class _217
    {
        public static bool ContainsDuplicate(int[] nums)
        {

            #region 字典解法 时间空间都为N  字典是C#中的hash
            ////bool res = true;
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //        res = true;
            //    else
            //        dic.Add(nums[i], 1);
            //}           
            //return res;
            #endregion
            #region 排序写法
            //Array.Sort<int>(nums);//C#中的Array.Sort（）应该是快排 时间为O(NlogN) 空间为递归栈的O(logN)
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    if (nums[i]==nums[i+1])
            //    {
            //        return true;
            //    }
            //}
            //return false;
            #endregion
            #region 利用集合的去重性质  //性能8太行
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
                set.Add(nums[i]);
            if (set.Count==nums.Length)
                return false;
            return true;
            #endregion

        }
    }
}
