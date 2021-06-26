using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//    给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

//有效字符串需满足：

//左括号必须用相同类型的右括号闭合。
//左括号必须以正确的顺序闭合。

//来源：力扣（LeetCode）
//链接：https://leetcode-cn.com/problems/valid-parentheses
//著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    class _20
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            //char[] chars = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {

                if (stack.Count != 0 && Match(stack.Peek(), s[i]))
                    stack.Pop();
                else
                    stack.Push(s[i]);
            }
            return stack.Count == 0;
             
        }
        private static bool Match(char left,char right )
        {
            if (left=='('&&right==')')
            {
                return true;
            }
            if (left == '[' && right == ']')
            {
                return true;
            }
            if (left == '{' && right == '}')
            {
                return true;
            }
            return false;
        }
    }
}
