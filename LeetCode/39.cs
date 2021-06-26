using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _39//组合总和
    {
        IList<IList<int>> res = new List<IList<int>>();
        int index = 0;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            #region 完全背包问题 做不来
            //int len = candidates.Length;
            //int[,] dp = new int[len + 1, target + 1];//几种方法
            //for (int i = 0; i < len + 1; i++)
            //{

            //    for (int j = 0; j < target + 1; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        {
            //            dp[i, j] = 1;
            //        }
            //        else if (i == 0)
            //        {
            //            dp[i, j] = 0;
            //        }
            //        else if (j == 0)
            //        {
            //            dp[i, j] = 1;
            //        }
            //        else
            //        {
            //            if (j - candidates[i - 1] >= 0)
            //                dp[i, j] = dp[i - 1, j] + dp[i, j - candidates[i - 1]];
            //            else
            //                dp[i, j] = dp[i - 1, j];

            //        }
            //    }
            //}
            //return res;
            #endregion
            List<int> empty = new List<int>();
            Backtrack(candidates, target, empty, 0);
            return res;

        }
        private void Backtrack(int[] candidates, int target, IList<int> curList, int index)
        {
            if (target<0||index==candidates.Length)
            {
                return;
            }

            if (target==0)
            {
                IList<int> newlist = new List<int>(curList);
                res.Add(newlist);
                return;
            }
            Backtrack(candidates, target, curList, index + 1);
            if (target>=candidates[index])
            {
                curList.Add(candidates[index]);
                Backtrack(candidates, target - candidates[index], curList, index);
                curList.Remove(candidates[index]);
            }
           
           
        }
    }
}
