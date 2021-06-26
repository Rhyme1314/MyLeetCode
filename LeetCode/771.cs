using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _771//宝石与石头
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int res = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < jewels.Length; i++)
            {
                dic[jewels[i]] = 0;
            }
            for (int i = 0; i < stones.Length; i++)
            {
                if (dic.ContainsKey(stones[i]))
                {
                    dic[stones[i]]++;
                }
            }
            foreach (char c in dic.Keys)
            {
                res += dic[c];
            }
            return res;
        }
    }
}
