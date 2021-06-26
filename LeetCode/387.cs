using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _387//字符串中的第一个唯一字符
    {
        public int FirstUniqChar(string s)
        {
            #region 哈希表
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = i;
                }
                else
                {
                    dic[s[i]] = -1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]) && dic[s[i]] != -1)
                {
                    return i;
                }
            }
            return -1;
            #endregion



        }
    }
}
