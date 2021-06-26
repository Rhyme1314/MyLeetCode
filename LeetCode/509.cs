using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _509//斐波那契数列
    {
        public int Fib(int n)
        {
            int[] Fn = new int[n+1];
            return Fib2(n, Fn);
            #region 最简单的递归
            //if (n == 0) return 0;
            //if (n == 1) return 1;
            //return Fib(n - 1) + Fib(n - 2);
            #endregion
            #region 动态规划
            //if (n < 2) return n;
            //int p = 0; int q = 1; int r = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    p = q;
            //    q = r;
            //    r = p + q;
            //}
            //return r;

            #endregion
        }
        private int Fib2(int n, int[] Fn)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (Fn[n] != 0) return Fn[n];
            return Fn[n] = Fib2(n - 1,Fn) + Fib2(n - 2,Fn);
        }
    }
}
