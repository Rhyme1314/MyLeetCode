using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1239//串联字符串的最大长度
    {
        int res = 0;
        public int MaxLength(IList<string> arr)
        {
            DFS(arr, new HashSet<char>(), 0);
            return res;
        }
        private void DFS(IList<string> arr, HashSet<char> set, int index)
        {
            if (index==arr.Count)
                return;
            
            for (int i = index; i < arr.Count; i++)
            {
                HashSet<char> newset = new HashSet<char>(set);
                bool isMatch = true;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (!newset.Add(arr[i][j]))//如果添加失败 说明 有重复
                        isMatch = false;
                }
                if (isMatch)//如果可以添加
                {
                    res = Math.Max(res, newset.Count);
                    DFS(arr, new HashSet<char>(newset), i + 1);
                }
                else DFS(arr, new HashSet<char>(set), i + 1);
            }
        }
    }
}
