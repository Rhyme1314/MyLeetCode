using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _316//去除重复字母
    {
        public string RemoveDuplicateLetters(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int n = s.Length;
            for (int i = 0; i < n; i++)
                dic[s[i]] = i;//用一个hashmap来存每个char在s中的位置
            Stack<char> stack = new Stack<char>();
            int index = 0;
            while (index < n)
            {
                while (index < n && (stack.Count == 0 || stack.Peek() < s[index]) && !stack.Contains(s[index]))
                    stack.Push(s[index++]);
                if (index >= n)
                    break;
                if (stack.Contains(s[index])) { index++; continue; }
                while (stack.Count != 0 && (stack.Peek() > s[index] && dic[stack.Peek()] >= index))//说明不是最后一个元素 可以删
                    stack.Pop();
                stack.Push(s[index++]);
            }
            char[] res = new char[stack.Count];
            for (int i = res.Length - 1; i >= 0; i--)
                res[i] = stack.Pop();
            return new string(res);


        }
    }
}
