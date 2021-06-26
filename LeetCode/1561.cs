using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1561//你可以获得的最大硬币数目
    {
        public int MaxCoins(int[] piles)
        {
            int n = piles.Length;
            Array.Sort(piles);
            int res = 0;
            int s = 0;int l = n - 1; int m = l - 1;
            while (l-s>=3)
            {
                res += piles[m];
                s++;l -= 2;
                m = l - 1;
            }
            return res;
        }
    }
}
