using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _12//整数转罗马数字
    {
        public string IntToRoman(int num)
        {
            StringBuilder sb = new StringBuilder();
            int M = num / 1000;
            for (int i = 0; i < M; i++)
            {
                sb.Append('M');
            }
            num = num % 1000;
            int C = num / 100;
            if (C == 9)
            {
                sb.Append("CM");
            }
            else if (C >= 5)
            {
                sb.Append('D');
                for (int i = 0; i < C - 5; i++)
                {
                    sb.Append('C');
                }
            }
            else if (C == 4) sb.Append("CD");
            else
            {
                for (int i = 0; i < C; i++)
                {
                    sb.Append('C');
                }
              
            }
            num = num % 100;
            int X = num / 10;

            if (X == 9)
            {
                sb.Append("XC");
            }
            else if (X >= 5)
            {
                sb.Append('L');
                for (int i = 0; i < X - 5; i++)
                {
                    sb.Append('X');
                }
            }
            else if (X == 4) sb.Append("XL");
            else
            {
                for (int i = 0; i < X; i++)
                {
                    sb.Append('X');
                }

            }
            num = num % 10;


            int I = num;

            if (I == 9)
            {
                sb.Append("IX");
            }
            else if (I >= 5)
            {
                sb.Append('V');
                for (int i = 0; i < I - 5; i++)
                {
                    sb.Append('I');
                }
            }
            else if (I == 4) sb.Append("IX");
            else
            {
                for (int i = 0; i < I; i++)
                {
                    sb.Append('I');
                }

            }
            return sb.ToString();
        }
    }
}
