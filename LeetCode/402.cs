using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _402//移掉 K 位数字
    {
        //单调栈
        public string RemoveKdigits(string num, int k)
        {
            string res = "";int count = num.Length-k;//count为剩下的字符串长度
            if (count==0) return "0";
            Stack<char> stack = new Stack<char>();//单调栈
            int index = 0;
            while (index<num.Length)
            {
                while (index < num.Length&&(stack.Count==0 || stack.Peek()<=num[index]))
                {
                    stack.Push(num[index++]);
                }
                if (index==num.Length)
                    break;
                //  1 0 0 0 1 k =4
               while (stack.Count!=0&&stack.Peek()>num[index]&&stack.Count+num.Length-index-1>=count)
                {
                    stack.Pop();
                }
                stack.Push(num[index++]);
            }
            Stack<char> stack2 = new Stack<char>();//单调栈
            while ( stack.Count>count)
            {
                stack.Pop();
            }
            while (stack.Count!=0)
            {
                stack2.Push(stack.Pop());
            }
            while (stack2.Count!=0&&stack2.Peek()=='0')
            {
                stack2.Pop();
            }
            if (stack2.Count==0)
            {
                return "0";
            }
            while (stack2.Count!=0)
            {
                res += stack2.Pop();
            }
            return res;
        }
    }
}
