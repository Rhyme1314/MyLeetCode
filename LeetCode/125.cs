using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _125//验证回文串
    {
        public bool IsPalindrome(string s)
        {
            #region 利用额外空间
            //StringBuilder sgood = new StringBuilder();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (Char.IsLetterOrDigit(s[i]))
            //    {
            //        sgood.Append(s[i]);
            //    }
            //}
            //string sgoodstr = sgood.ToString().ToLower();
            //int left = 0; int right = sgoodstr.Length - 1;
            //while (right >= left)
            //{
            //    if (sgoodstr[left] == sgoodstr[right])
            //    {
            //        left++; right--;
            //    }
            //    else return false;
            //}
            //return true;
            #endregion
            #region 原字符串直接操作
           // s.ToLower();
            int left = 0; int right = s.Length - 1;
            while (right>=left)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else if (char.ToLower(s[left])   ==char.ToLower(s[right]) )
                {
                    left++; right--;
                }
                else return false;
            }
            return true;
            #endregion

            //for (int i = sgoodstr.Length-1; i >=0; i--)
            //{
            //    sgood_rev.Append(sgoodstr[i]);
            //}
            //return sgood.ToString().Equals(sgood_rev.ToString());
        }
    }
}
