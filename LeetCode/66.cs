using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _66//加一
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits[0]==0)
                return new int[] { 1 };
            int n = digits.Length;
            for (int i =n-1; i>=0; i--)
            {
                digits[i]++;
                digits[i] = digits[i] % 10;
                if (digits[i]!=0)
                    return digits;

            }
                digits = new int[n + 1];
                digits[0] = 1;
            return digits;
            
        }
    }
}
