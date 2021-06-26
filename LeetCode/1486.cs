using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _1486//数组异或操作
    {
        public int XorOperation(int n, int start)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res = res ^ (start + 2 * i);
            }
            return res;
        }
    }
}
