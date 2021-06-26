using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _10//正则表达式匹配
    {
        public bool IsMatch(string s, string p)
        {
            int slen = s.Length;
            int plen = p.Length;
            bool[,] dp = new bool[slen + 1, plen + 1];
            //  dp[0, 0] = true;
            for (int j = 0; j <= plen; j++)
            {
                for (int i = 0; i <= slen; i++)
                {
                    if (j == 0 && i == 0)
                    {
                        dp[i, j] = true;
                    }
                    else if (j == 0 || i == 0)
                    {
                        dp[i, j] = false;
                    }
                    else if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*' && ((s[i - 1] == p[j - 2]) || (p[j - 2] == '.')))
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i, j - 2];//前者为当前的s[i]被*代表了 后者不被代表
                    }
                    else if (p[j - 1] == '*')//当前s[i]已经不能被*代表了
                    {
                        dp[i, j] = dp[i, j - 2];
                    }
                }
            }

            return dp[slen, plen];
        }
    }
}
