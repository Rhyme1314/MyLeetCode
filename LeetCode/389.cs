using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//给定两个字符串 s 和 t，它们只包含小写字母。

//字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。

//请找出在 t 中被添加的字母。
    class _389
    {
        public  static char FindTheDifference(string s, string t)
        {
            #region 两个字典
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //Dictionary<char, int> dic2 = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!dic.ContainsKey(s[i]))
            //        dic[s[i]] = 1;
            //    else
            //        dic[s[i]] += 1;
            //}
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (!dic2.ContainsKey(t[i]))
            //        dic2[t[i]] = 1;
            //    else
            //        dic2[t[i]] += 1;
            //}
            //foreach (char key in dic2.Keys)
            //{
            //    if (!dic.ContainsKey(key))
            //        return key;
            //    if (dic[key] != dic2[key])
            //        return key;
            //}
            //return ' ';
            #endregion
            #region 一个字典
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic[s[i]] = 1;
                else
                    dic[s[i]] += 1;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!dic.ContainsKey(t[i]))
                    return t[i];
                else
                    dic[t[i]] -= 1;
            }
            foreach (char key in dic.Keys)
            {
                if (dic[key] < 0)
                    return key;
            }
            throw new ArgumentException("不存在增加的元素");
            #endregion
            

        }
    }
}
