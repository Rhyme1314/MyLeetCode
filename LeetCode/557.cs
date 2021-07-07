using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _557//反转字符串中的单词 III
    {
        public string ReverseWords(string s)
        {
            char[] arr = s.ToCharArray();
            int left = 0;int right = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' '|| i ==arr.Length-1)
                {
                    right = i - 1;
                        if (i==arr.Length-1)
                            right = i;
                    while (right >= left)
                    {
                        Swap(arr, left, right);
                        right--;
                        left++;
                    }
                    left = i + 1;
                }
            }
            return new string(arr);
        }

        private void Swap(char[] arr, int left, int right)
        {
            char temp = arr[left];arr[left] = arr[right];arr[right] = temp;
        }
    }
}
