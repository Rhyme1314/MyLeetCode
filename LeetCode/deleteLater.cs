using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class deleteLater
    {
        //IList<IList<int>> res = new List<IList<int>>();

        //public IList<IList<int>> test(int n ,int m,int s)
        //{
        //    List<int>[,] dp = new List<int>[m+1, s + 1];
        //    for (int i = 1; i < m+1; i++)
        //    {
        //        dp[i, 0] = new List<int>();
        //        for (int j = 1; j < s+1; j++)
        //        {
        //            dp[i, j] = dp[i - 1, j];
        //            if (j>=i)
        //            {
        //                dp[i, j] = new List<int>(dp[i, j - i]);
        //                dp[i, j].Add(i);
        //            }
        //        }
        //    }
        //    for (int i = 1; i < m+1; i++)
        //    {
        //        if (dp[i,s].Count==n)
        //            res.Add(dp[i, s]);
        //    }

        //    return res;
        //}
    }
        #region 回溯
        //private void Backtrack(int n, int m, int s, int index, List<int> curList)
        //{
        //    if (s < 0 || index > m)
        //        return;
        //    if (s == 0 && curList.Count == n)
        //    {
        //        res.Add(new List<int>(curList));
        //        return;
        //    }
        //    Backtrack(n, m, s, index + 1, curList);
        //    if (s >= index)
        //    {
        //        curList.Add(index);
        //        Backtrack(n, m, s - index, index, curList);
        //        curList.Remove(index);
        //    }
        //}
        #endregion

    }
