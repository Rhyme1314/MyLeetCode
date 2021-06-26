using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _5//最长回文子串  //才发现自己原来这么菜 会写个P的DP
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length; int maxLen = 1; int begin = 0;
            bool[,] dp = new bool[n, n];//dp[i,j]表示以i为开头 i->j 是否为回文
            for (int i = 0; i < n - 1; i++)
            {
                dp[i, i] = true;//单个字符肯定是回文子串
                dp[i, i + 1] = s[i] == s[i + 1];//两个相连的也要初始化
            }
            dp[n - 1, n - 1] = true;
            for (int L = 2; L <= n; L++)
            {
                for (int i = 0; i < n; i++)
                {
                    int j = i + L - 1;
                    if (j >= n) break;
                    if (L == 2)
                    {
                        dp[i, j] = s[i] == s[j];
                    }
                    else
                    {
                        dp[i, j] = dp[i + 1, j - 1] && s[i] == s[j];
                    }

                    if (dp[i, j])
                    {
                        maxLen = maxLen > L ? maxLen : L;
                        begin = maxLen > L ? begin : i;
                    }
                }
            }
            return s.Substring(begin, maxLen - 1);



        }
    }
}
