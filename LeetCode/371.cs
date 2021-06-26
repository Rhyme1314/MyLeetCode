using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _371//两整数之和
    {
        public int GetSum(int a, int b)//位运算题目 根本不懂
        {
            int XOR = a ^ b;
            int AND = a & b;
            while (AND!=0)
            {
               AND= AND << 1;
                int temp = XOR ^ AND;
                AND = XOR & AND;
                XOR = temp;
            }
            return XOR;
        }
    }
}
