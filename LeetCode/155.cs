using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    class MinStack//最小栈
    {
        int curMin = int.MaxValue;
        Stack<int> stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            curMin = Math.Min(val, curMin);
        }

        public void Pop()
        {
            if (stack.Pop()==curMin)
            {
                curMin = int.MaxValue;
                foreach (int num in stack)
                    curMin = Math.Min(curMin, num);
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return curMin;
        }
    }
}
