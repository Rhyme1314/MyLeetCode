using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //给定两个整数 n 和 k，返回 1 ... n 中所有可能的 k 个数的组合。
    class _77//组合
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            #region 回溯法
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> empty = new List<int>();
            Backtracking(n, k, 1, res, empty);
            return res;
            #endregion
        }
        private void Backtracking(int n, int k, int index, IList<IList<int>> res, IList<int> curlist)
        {
            if (curlist.Count==k)
            {
                List<int> newlist = new List<int>(curlist);
                res.Add(newlist);
                return;
            }
            for (int i = index; i <= n; i++)
            {
                curlist.Add(i);
                Backtracking(n, k, i + 1, res, curlist);
                curlist.Remove(i);
            }
        }
    }
}
