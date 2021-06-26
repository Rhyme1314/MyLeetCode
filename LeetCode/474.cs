using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _474//一和零  错误
    {
        public int FindMaxForm(string[] strs, int m, int n)//m为0的个数  n为1的个数
        {
            #region DP解01背包问题 双重背包条件
            //int[,,] dp = new int[strs.Length + 1, m + 1, n + 1];
            ////dp[i,j,k]  代表 从前1~i个元素中能凑出得 0的个数小于j 1的个数小于k 的最多的元素个数
            //for (int i = 1; i < strs.Length + 1; i++)
            //{
            //    for (int j = 0; j < m + 1; j++)
            //    {
            //        for (int k = 0; k < n + 1; k++)
            //        {
            //            int curZero; int curOne;
            //            GetZeroAndOneCount(strs[i - 1], out curZero, out curOne);
            //            if (j == 0 && k == 0)
            //            {
            //                dp[i, j, k] = 0;
            //            }
            //            else
            //            {
            //                if (j - curZero >= 0 && k - curOne >= 0)
            //                    dp[i, j, k] = Math.Max(dp[i - 1, j, k], dp[i - 1, j - curZero, k - curOne] + 1);
            //                else
            //                    dp[i, j, k] = dp[i - 1, j, k];
            //            }
            //        }
            //    }
            //}
            //return dp[strs.Length, m, n];
            #endregion

            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < strs.Length; i++)
            {
                int curZero; int curOne;
                GetZeroAndOneCount(strs[i], out curZero, out curOne);
                for (int j = m; j >= curZero; j--)
                {
                    for (int k = n; k >= curOne; k--)
                    {
                        dp[j, k] = Math.Max(dp[j, k], dp[j - curZero, k - curOne] + 1); 
                    }
                }
            }
            return dp[m, n];
        }

        //287340

        private void GetZeroAndOneCount(string str, out int curZeroC, out int curOneC)
        {
            curZeroC = 0; curOneC = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    curOneC++;
                }
                else curZeroC++;
            }
        }
    }
}

