using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _17//电话号码的字母组合
    {
        IList<string> res = new List<string>();
        Dictionary<int, char[]> dic = new Dictionary<int, char[]>();

        public IList<string> LetterCombinations(string digits)
        {
            for (int i = 2; i <= 6; i++)
            {
                dic[i] = new char[] { (char)((i-1)*3-3+'a'), (char)((i - 1) * 3 - 2 + 'a'), (char)((i - 1) * 3 - 1 + 'a') };
            }
            dic[7] = new char[] { 'p', 'q', 'r', 's' };
            dic[8] = new char[] { 't','u','v' };
            dic[9] = new char[] { 'w', 'x', 'y', 'z' };
            DFS(digits, 0, "");
            return res;
        }
        private void DFS(string digits,int index,string str)
        {
            int n = digits.Length;
            if (index==n)
            {
                res.Add(str);
                return; 
            }
                int key = digits[index] - '0';
                DFS(digits, index + 1, str + dic[key][0]);
                DFS(digits, index + 1, str + dic[key][1]);
                DFS(digits, index + 1, str + dic[key][2]);
            if (dic[key].Length==4)
                DFS(digits, index + 1, str + dic[key][3]);
            
        }
    }
}
