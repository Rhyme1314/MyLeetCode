using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _347//前 K 个高频元素
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int n = nums.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = 1;
                }
                else {
                    dic[nums[i]]++;
                }
            }
            List<int> list = new List<int>();
            foreach (var key in dic.Keys)
            {
                list.Add(key);
            }
            list.Sort((int key1, int key2) => { return dic[key1] - dic[key2]; });
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = list[i];
            }
            return res;
        }
    }
}
