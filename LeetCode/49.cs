using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _49//字母异位词分组
    {
        IList<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            int n = strs.Length;int level = 0;
            for (int i = 0; i < n; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string str = new string(chars);
                if (!dic.ContainsKey(str))
                {
                    dic[str] = level++;
                }
            }
            for (int i = 0; i < level; i++)
            {
                res.Add(new List<string>());
            }
            for (int i = 0; i < n; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string str = new string(chars);
                if (!dic.ContainsKey(str))
                {
                    res[dic[str]].Add(strs[i]);
                }
            }
            return res;
        }
    }
}
