using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _168//Excel表列名称
    {
        public string ConvertToTitle(int columnNumber)
        {
            string res = "";
            StringBuilder sb = new StringBuilder();
            while (columnNumber>0)
            {
                int last = (columnNumber - 1) % 26 + 1;
                sb.Append((char)(last + 'A' - 1));
                columnNumber = columnNumber / 26;
            }
            for (int i = sb.Length-1; i>=0 ; i--)
            {
                res += sb[i];
            }
            return res;
        }
    }
}
