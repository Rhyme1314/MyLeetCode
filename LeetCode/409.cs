using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _409//最长回文串
    {
        public int LongestPalindrome(string s)
        {
            if (s.Length<=1)
                return s.Length;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic[s[i]] = 1;
                else dic[s[i]]++;
            }
            bool flag = true;int res = 0;
            foreach (char key in dic.Keys)
            {
                if (flag && dic[key]%2 == 1)
                {
                    res++; flag = false;
                }
                if (dic[key] >= 2)
                {
                    res +=2* (dic[key]/2);
                }
                    
            }
            return res;
        }
    }
}
