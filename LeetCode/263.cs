using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _263//丑数
    {
        public bool IsUgly(int n)
        {
            #region DP
            //if (n <= 0 || (n!=1&&n % 2 != 0 && n % 3 != 0 && n % 5 != 0))
            //    return false;
            //bool[] dp = new bool[n + 1];
            //dp[1] = true;
            //for (int i = 2; i < n + 1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        dp[i] = dp[i / 2];
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        dp[i] = dp[i / 3];
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        dp[i] = dp[i / 5];
            //    }
            //}
            //return dp[n];
            #endregion
            if (n <= 0 || (n != 1 && n % 2 != 0 && n % 3 != 0 && n % 5 != 0))
                return false;
            while (n!=1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else if (n % 3 == 0)
                {
                    n /= 3;
                }
                else if (n % 5 == 0)
                {
                    n /= 5;
                }
                else
                    return false;
            }
            return true;

        }
    }
}
