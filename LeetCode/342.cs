using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _342//4的幂
    {
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0)
                return false;
            // int m = (int)Math.Sqrt(n);
            if ((n & (n - 1)) == 0)
            {
                while (n!=1&&n!=2)
                {
                    n >>= 2;
                }
                return n==1;
            }
            return false;
        }
    }
}
