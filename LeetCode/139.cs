using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _139//单词拆分
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            #region 完全背包问题解法
            int n = wordDict.Count;
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 0; i < s.Length + 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int wordSize = wordDict[j].Length;
                    if (i - wordSize >= 0 && s.Substring(i - wordSize, wordSize) == wordDict[j])
                    {
                        dp[i] = dp[i] || dp[i - wordSize];
                    }
                }
            }
            return dp[s.Length];
            #endregion

        }
    }
}
