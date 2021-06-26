using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _3//无重复字符的最长子串
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int n = s.Length;int left = 0;int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic[s[i]] = i;
                else if (dic.ContainsKey(s[i]) && left <= dic[s[i]])
                {
                    left = dic[s[i]] + 1;
                    dic[s[i]] = i;
                }
                else if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = i;
                }
                res = Math.Max(i - left+1, res);
            }
            return res;
        }
    }
}
