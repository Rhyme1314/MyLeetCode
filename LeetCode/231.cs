using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _231//2的幂
    {
        public bool IsPowerOfTwo(int n)
        {
            int res = n;
            if (res<=0)
                return false;
            if ((res&(res-1))==0)
                return true;
            return false;
        }
    }
}
