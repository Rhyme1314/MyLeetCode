using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //编写一个函数，其作用是将输入的字符串反转过来。输入字符串以字符数组 char[] 的形式给出。
    //不要给另外的数组分配额外的空间，你必须原地修改输入数组、使用 O(1) 的额外空间解决这一问题。
    //你可以假设数组中的所有字符都是 ASCII 码表中的可打印字符。
    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/reverse-string
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _344//反转字符串
    {
        public void ReverseString(char[] s)
        {
            #region 双指针 
            //if (s.Length == 0) return;

            //int left = 0;
            //int right = s.Length-1;
            //while (right>left)
            //{
            //    Swap(s, left, right);
            //    left++;right--;
            //}
            #endregion
            #region 递归
            Func(s, 0, s.Length - 1);
            #endregion
        }

        private void Swap(char[] s, int left, int right)
        {
            char temp = s[left]; s[left] = s[right];s[right] = temp;
        }

        private void Func(char[] chars,int left,int right)
        {
            if (left>=right)
                return;
            Func(chars, left + 1, right -1);
            Swap(chars, left, right);
        }
    }
}
