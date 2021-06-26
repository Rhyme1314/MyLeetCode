using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    给你字符串 s 和整数 k 。

//请返回字符串 s 中长度为 k 的单个子字符串中可能包含的最大元音字母数。

//英文中的 元音字母 为（a, e, i, o, u）

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _1456//定长 子串 中 元音 的最大数目
    {
        public int MaxVowels(string s, int k)
        {
            int left = 0;int right = k - 1;
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                if (isVowel(s[i]))
                    sum++;
            }
            int res = sum;
            for (int i = k; i < s.Length; i++)
            {
                right++;
                if (isVowel(s[right]))
                    sum++;
                if (isVowel(s[left]))
                    sum--;
                left++;
                if (res<sum)
                    res = sum;
            }
            return res;
        }
        private bool isVowel(char c)
        {
            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }
}
