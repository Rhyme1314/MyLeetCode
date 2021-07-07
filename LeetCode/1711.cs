using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1711// 大餐计数
    {
        public int CountPairs(int[] deliciousness)
        {
            #region 暴力解法 超时
            //int res = 0;
            //int n = deliciousness.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        int curNum = deliciousness[i] + deliciousness[j];
            //        while ((curNum & 1) == 0)//curNum为偶数
            //        {
            //            curNum = curNum >> 1;
            //        }
            //        if (curNum == 1)
            //        {
            //            res++;
            //        }
            //    }
            //}
            //return res;
            #endregion
            #region 巨复杂还错了
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //int n = deliciousness.Length; int res = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (!dic.ContainsKey(deliciousness[i]))
            //        dic[deliciousness[i]] = 1;
            //    else dic[deliciousness[i]]++;
            //}
            //HashSet<int> set = new HashSet<int>(deliciousness);
            //List<int> list = new List<int>(set);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = i; j < list.Count; j++)
            //    {
            //        int curNum = list[i] + list[j];
            //        while ((curNum & 1) == 0)
            //        {
            //            curNum = curNum >> 1;
            //        }
            //        if (curNum == 1)
            //        {
            //            if (i == j)
            //            {
            //                res += GetNum(dic[list[i]]) / 2;
            //            }
            //            else res += (dic[list[i]] * dic[list[j]]);
            //        }
            //    }
            //}
            //return res % 1000000007;
            #endregion
            const int MOD = 1000000007;
            int maxVal = 0;
            foreach (var item in deliciousness)
            {
                maxVal = Math.Max(item, maxVal);
            }
            int maxSum = maxVal * 2;int res = 0;
            int n = deliciousness.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int val = deliciousness[i];
                for (int sum = 1; sum <= maxSum; sum<<=1)
                {
                    int count = 0;
                    dic.TryGetValue(sum - val, out count);
                    res =(res+ count)%MOD;
                }
                if (!dic.ContainsKey(val))
                {
                    dic[val] = 1;
                }
                else dic[val]++;
            }
            return res%MOD;

        }
        //阶乘
        private int GetNum(int n)
        {
            int num = n;
            while (n!=1)
            {
                num *= --n;
            }
            return num;
        }
    }
}
