using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _451//根据字符出现频率排序
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic[s[i]] = 1;
                else dic[s[i]]++;
            }
            List<char> list = new List<char>(dic.Keys);
            list.Sort((char a, char b) => { return dic[b] - dic[a]; });
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                while (dic[list[i]]-->0)
                {
                    sb.Append(list[i]);
                }
            }
            return sb.ToString();
        }
    }
}
