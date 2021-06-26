using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class 剑指Offer50//第一个只出现一次的字符
    {
        public char FirstUniqChar(string s)
        {
            #region 字典存频数
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!dic.ContainsKey(s[i]))
            //        dic[s[i]] = 1;
            //    else
            //        dic[s[i]]++;
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dic[s[i]] == 1)
            //        return s[i];
            //}
            //return ' ';
            #endregion
            #region 字典存索引
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int resindex = int.MaxValue-1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = i;
                }
                else
                {
                    dic[s[i]] = int.MaxValue;
                }
            }
            foreach (char keys in dic.Keys)
            {
                resindex = Math.Min(resindex, dic[keys]);
            }
            return resindex == int.MaxValue - 1 ? ' ' : s[resindex];
            #endregion

        }
    }
}
