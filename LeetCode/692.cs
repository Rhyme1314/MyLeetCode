using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    class _692
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public IList<string> TopKFrequent(string[] words, int k)
        {
            #region 字典+委托排序
            for (int i = 0; i < words.Length; i++)
            {
                if (!dic.ContainsKey(words[i]))
                    dic[words[i]] = 1;
                else
                    dic[words[i]] += 1;
            }
            List<string> res = new List<string>();
            foreach (string key in dic.Keys)
            {
                res.Add(key);
            }
            res.Sort((string a1, string a2) =>
            {
                if (dic[a1] != dic[a2])//返回的值大于0  a2排在前面
                    return dic[a2] - dic[a1];// >0  a2排在前面
                else
                    return a1.CompareTo(a2);//根据F12的解释 若值>0   a2排在前面
            }
            );
            return res.GetRange(0, k);
            #endregion

        }
    }

}
