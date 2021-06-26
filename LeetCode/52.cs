using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _52//N皇后II
    {
        int res =0;
        public int TotalNQueens(int n)
        {
            int[] queens = new int[n];
            Backtrack2(n, 0, queens);
            return res;
        }
        private bool isMatch(int k, int[] queens)
        {
            for (int i = 0; i < k; i++)
            {
                if (queens[i] == queens[k] || Math.Abs(queens[k] - queens[i]) == (k - i))//皇后不兼容
                {
                    return false;
                }
            }
            return true;
        }
        private void Backtrack2(int n, int k, int[] queens)
        {
            if (k == n)
            {
                res++;
                return;
            }

            for (int i = 0; i < n; i++)
            {
                queens[k] = i;
                if (!isMatch(k, queens))
                {
                    queens[k] = n;
                    continue;
                }
                Backtrack2(n, k + 1, queens);
                queens[k] = n;
            }
        }
    }
}
