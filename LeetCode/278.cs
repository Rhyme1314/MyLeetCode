using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _278//第一个错误的版本
    {
        public int FirstBadVersion(int n)
        {
            int left = 1;int right = n;
            while (right>left)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {//中间值是错误版本
                    right = mid - 1;
                }
                else
                {//中间不是错误版本
                    left = mid + 1;
                }
            }
            if (IsBadVersion(right))
            {
                return right;
            }
            else return right + 1;
        }
        bool IsBadVersion(int version) => true;
    }
}
