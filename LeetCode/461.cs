using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _461//汉明距离 //没做
    {
        public int HammingDistance(int x, int y)
        {
            int res = 0;int num = x ^ y;
            while (num!=0)
            {
                if ((num & 1) == 1)
                {
                    res++;
                }
                num >>= 1;
            }
            return res;
               
            
        }
    }
}
