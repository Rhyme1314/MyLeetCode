using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _202//快乐数
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();
            while (!set.Contains(n))
            {
                set.Add(n);
                n = getNext(n);
                if (n==1)
                    return true;
            }
            return false;
        }
        private int getNext(int n)
        {
            int next = 0;
            while (n>0)
            {
                int d = n % 10;
                n /= 10;
                next += d * d;
            }
            return next;
        }
    }
}
