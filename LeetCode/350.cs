using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _350// 两个数组的交集 II
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dic.ContainsKey(nums1[i]))
                    dic[nums1[i]] = 1;
                else
                    dic[nums1[i]] += 1;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] > 0)
                {
                    list.Add(nums2[i]);
                    dic[nums2[i]]--;
                }
            }
            int[] res = list.ToArray();
            return res;

        }
    }
}
