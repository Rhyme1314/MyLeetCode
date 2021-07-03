using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _13//罗马数字转整数
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic['I'] = 1;
            dic['V'] = 5;
            dic['X'] = 10;
            dic['L'] = 50;
            dic['C'] = 100;
            dic['D'] = 500;
            dic['M'] = 1000;
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && dic[s[i]] < dic[s[i + 1]])
                {
                    sum -= dic[s[i]];
                }
                else sum += dic[s[i]];
            }
            return sum;
        }
    }
}
